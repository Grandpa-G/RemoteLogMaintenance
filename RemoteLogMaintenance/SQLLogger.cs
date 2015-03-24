using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace RemoteLogMaintenance
{
    public partial class SQLLogger : Form
    {
        RemoteUtils ru = new RemoteUtils();
        private enum SqlType
        {
            Unknown,
            Sqlite,
            Mysql
        }

        private SqlType dbType;
        public SQLLogger()
        {
            InitializeComponent();
            lblVersion.Text = "Version " + Assembly.GetExecutingAssembly().GetName().Version.ToString();

            restoreSettings();
            startLog();
        }
        private void startLog()
        {
            listStats.Items.Clear();
            dataListLog.Rows.Clear();

             dtStartSearch.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            dtStartSearch.Format = DateTimePickerFormat.Custom;
            dtEndSearch.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            dtEndSearch.Format = DateTimePickerFormat.Custom;

            toolTip.SetToolTip(txtSearchMessage, "Include text for fuzzy search (i.e. %xxxx%)");
            toolTip.SetToolTip(dtStartSearch, "Check box to include in search criteria.");
            toolTip.SetToolTip(dtEndSearch, "Check box to include in search criteria.");
            toolTip.SetToolTip(txtRowLimit, "Enter number of rows to limit criteria or refresh.");

            toolTip.SetToolTip(searchLog, "Start Search");
            toolTip.SetToolTip(clearSearch, "Resets search criteria.");
 
            dtStartSearch.Checked = false;
            dtEndSearch.Checked = false;
            if (ru.getToken())
            {
                refreshLog_Click(null, null);
            }
        }

        private void fillStats()
        {
            listStats.Items.Clear();
            Stats logList = new Stats();
            logList = ru.getStats();
            if (logList.DBStats.DBType.ToString().Equals("SQLite"))
                dbType = SqlType.Sqlite;
            else
                dbType = SqlType.Mysql;
            lblDatabaseSize.Text = "DB size " + logList.DBStats.DBSize.ToString() + " (MB) " + logList.DBStats.DBType.ToString();
            lblLogSize.Text = "Table size " + logList.DBStats.TableRows.ToString() + " rows, " + logList.DBStats.TableSize.ToString() + "(MB)";
            foreach (LogStat log in logList.LogStats)
            {
                ListViewItem item = new ListViewItem(log.Year.ToString());
                item.SubItems.Add(log.Month.ToString());
                item.SubItems.Add(log.Count.ToString());

                listStats.Items.Add(item);
            }
            lblVersion.Text = lblVersion.Text + " [dll version " + logList.DBStats.Version + "]";
        }
        private void fillLogList(string searchClause)
        {
            dataListLog.Rows.Clear();
            List<LogList> logList = new List<LogList>();
            logList = ru.getQuery(searchClause);
            lblRowCount.Text = string.Format("{0} entries found.", logList.Count);
            foreach (LogList log in logList)
                dataListLog.Rows.Add(false, log.ID, log.TimeStamp, log.LogLevel, log.Caller, log.Message);
        }

        private void dataListLog_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return; //check if row index is not selected
            if (e.ColumnIndex != 0)
                return;
            DataGridViewCheckBoxCell cbc = (DataGridViewCheckBoxCell)dataListLog.CurrentCell;
            DataGridViewCheckBoxCell chk = new DataGridViewCheckBoxCell();
            chk = (DataGridViewCheckBoxCell)dataListLog.Rows[e.RowIndex].Cells[0];
            if (chk.Value == null)
                chk.Value = false;
            switch (chk.Value.ToString())
            {
                case "False":
                    chk.Value = true;
                    dataListLog.Rows[e.RowIndex].Selected = true;
                    break;
                case "True":
                    chk.Value = false;
                    dataListLog.Rows[e.RowIndex].Selected = false;
                    break;
            }
        }

        private void refreshLog_Click(object sender, EventArgs e)
        {
            searchLog_Click(null, null);
            fillStats();
        }

        private void chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            bool selected = chkSelectAll.Checked;
            foreach (DataGridViewRow row in dataListLog.Rows)
            {
                row.Cells[0].Value = selected;
                row.Selected = selected;
            }
        }

        private void clearSearch_Click(object sender, EventArgs e)
        {
            txtSearchMessage.Text = "";
            dtStartSearch.Text = "03/1/2015 00:00:00";
            dtEndSearch.Text = "01/1/2018 00:00:00";
            dtStartSearch.Checked = false;
            dtEndSearch.Checked = false;
        }

        private void searchLog_Click(object sender, EventArgs e)
        {
            string whereClause = "";
            string and = " where ";
            string limit = "";
            string orderby = " order by id desc ";
            if (txtSearchMessage.Text.Length > 0)
            {
                whereClause = whereClause + and + " message like '%" + txtSearchMessage.Text + "%'";
                and = " and ";
            }

            if (dtStartSearch.Checked)
            {
                if(dbType == SqlType.Mysql)
                whereClause = whereClause + and + " timestamp>= STR_TO_DATE('" + dtStartSearch.Text + "','%m/%d/%Y %H:%i:%s')";
                else
                    whereClause = whereClause + and + " timestamp>= '" + returnDate(dtStartSearch.Text) + "'";
                and = " and ";
            }
            if (dtEndSearch.Checked)
            {
                if (dbType == SqlType.Mysql)
                    whereClause = whereClause + and + " timestamp<= STR_TO_DATE('" + dtEndSearch.Text + "','%m/%d/%Y %H:%i:%s')";
                else
                    whereClause = whereClause + and + " timestamp<= '" + returnDate(dtEndSearch.Text) + "'";
                and = " and ";
            }
            if (txtRowLimit.Text.Length > 0)
            {
                try
                {
                    int number = Int32.Parse(txtRowLimit.Text);
                    limit = " limit " + number;
                }
                catch (FormatException)
                {
                    limit = "";
                }
                catch (OverflowException)
                {
                    limit = "";
                }
            }
            whereClause = whereClause + orderby + limit;
            fillLogList(whereClause);
        }

        private string returnDate(string date)
        {
            string newDate = "";

            if(date.Length > 0)
            newDate = date.Substring(6, 4) + "-" + date.Substring(0, 2) + "-" + date.Substring(3, 2) + " " + date.Substring(11);
            return newDate;
        }
        private void dtStartSearch_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            string deleteList = "";
            string comma = "";
            foreach (DataGridViewRow row in dataListLog.Rows)
            {
                DataGridViewCheckBoxCell chk = row.Cells[0] as DataGridViewCheckBoxCell;

                if (Convert.ToBoolean(chk.Value) == true)
                {
                    deleteList = deleteList + comma + row.Cells[1].Value.ToString();
                    comma = ",";
                }
            }
            if (deleteList.Length > 0)
            {
                ru.deleteRows(deleteList);
                refreshLog_Click(null, null);
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            SaveFile();
        }
        private bool SaveFile()
        {
            // Displays a SaveFileDialog so the user can save the Image
            // assigned to Button2.
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Log file|*.log|Text file|*.txt|CSV file|*.csv";
            saveFileDialog1.Title = "Save a log file";

            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return false;
            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName == "")
                return false;

            // File type selected in the dialog box.
            // NOTE that the FilterIndex property is one-based.
            switch (saveFileDialog1.FilterIndex)
            {
                case 1:
                case 2:
                case 3:
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(saveFileDialog1.FileName))
                    {

                        foreach (DataGridViewRow row in dataListLog.Rows)
                        {
                            DataGridViewCheckBoxCell chk = row.Cells[0] as DataGridViewCheckBoxCell;

                            if (Convert.ToBoolean(chk.Value) == true)
                                file.WriteLine(row.Cells[2].Value.ToString() + "\t" + row.Cells[3].Value.ToString() + "\t" + row.Cells[4].Value.ToString() + "\t" + row.Cells[5].Value.ToString());
                        }
                    }
                    break;
            }
            return true;
        }

        private void btnSaveAndDelete_Click(object sender, EventArgs e)
        {
            if (SaveFile())
                btnDeleteSelected_Click(null, null);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (ShowDialog(ru.conn.UserId, "Enter Credentials"))
            {
                saveSettings();
                startLog();
            }
        }

        private void saveSettings()
        {
            Microsoft.Win32.RegistryKey exampleRegistryKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("RemoteLogMaintenance");
            exampleRegistryKey.SetValue("UserId", ru.conn.UserId);
            exampleRegistryKey.SetValue("Password", ru.conn.Password);
            exampleRegistryKey.SetValue("Server", ru.conn.Server);
            exampleRegistryKey.Close();
        }
        private void restoreSettings()
        {
            Microsoft.Win32.RegistryKey exampleRegistryKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("RemoteLogMaintenance");
            ru.conn.UserId = (string)exampleRegistryKey.GetValue("UserId");
            ru.conn.Password = (string)exampleRegistryKey.GetValue("Password");
            ru.conn.Server = (string)exampleRegistryKey.GetValue("Server");
            exampleRegistryKey.Close();

        }
        private bool ShowDialog(string text, string caption)
        {
            Credentials creds = new Credentials();
            creds.txtUserid.Text = ru.conn.UserId;
            creds.txtPassword.Text = ru.conn.Password;
            creds.txtServer.Text = ru.conn.Server;
 
            if (creds.ShowDialog() == DialogResult.OK)
            {
                ru.conn.UserId = creds.txtUserid.Text;
                ru.conn.Password = creds.txtPassword.Text;
               ru.conn.Server = creds.txtServer.Text;
                return true;
            }
 
            return false;
        }
    }

}
