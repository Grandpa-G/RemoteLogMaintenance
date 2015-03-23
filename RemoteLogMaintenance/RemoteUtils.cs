using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Net;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;

namespace RemoteLogMaintenance
{
    class RemoteUtils
    {
        public Connecton conn;

        public RemoteUtils()
        {
            conn = new Connecton();
        }
        private string token = "";

        public bool getToken()
        {

            string sendCommand = "http://" + conn.Server + "/" + "v2/token/create/" + conn.Password + "?username=" + conn.UserId;

            JObject results = Utils.GetHTTP(sendCommand);

            if (results == null)
            {
                MessageBox.Show("Invalid userid/password/server", "Remote Log Maintenance", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // this can be a string or null
            string status = (string)results["status"];
            if (status.Equals("200"))
            {
                if (results["token"] != null)
                    token = (string)results["token"];
            }
            else
            {
                token = "";
                return false;
            }

            return true;
        }
        public List<LogList> getQuery(string searchClause)
        {

            List<LogList> logList = new List<LogList>();
            string sendCommand;
            if (searchClause.Length > 0)
                sendCommand = "http://" + conn.Server + "/" + "SQLLogger/getRows" + "?token=" + token + "&search=" + WebUtility.UrlEncode(searchClause);
            else
                sendCommand = "http://" + conn.Server + "/" + "SQLLogger/getRows" + "?token=" + token;

            JObject results = Utils.GetHTTP(sendCommand);
            // Process each employee
            JArray rowList;
            // this can be a string or null
            string status = (string)results["status"];
            if (status.Equals("200"))
            {
                // this can be a string or array, how can we tell which it is
                JToken rows = results["Rows"];

                if (rows is JArray)
                {
                    // can pick one, or flatten array to a string
                    rowList = (JArray)rows;
                    foreach (var row in rowList)
                    {
                        LogList ll = new LogList((int)row["ID"], (string)row["TimeStamp"], (int)row["LogLevel"], (string)row["Caller"], (string)row["Message"]);
                        logList.Add(ll);
                    }
                }
            }
            return logList;
        }
        public Stats getStats()
        {

            Stats stats = new Stats();
            List<LogStat> logList = new List<LogStat>();
            DatabaseStat ds = null;

            string sendCommand;
            sendCommand = "http://" + conn.Server + "/" + "SQLLogger/getStats" + "?token=" + token;

            JObject results = Utils.GetHTTP(sendCommand);
            JArray rowList;
            // this can be a string or null
            string status = (string)results["status"];
            if (status.Equals("200"))
            {
                // this can be a string or array, how can we tell which it is
                JToken dbStats = results["Stats"];

                ds = new DatabaseStat((double)dbStats["DBSize"], (int)dbStats["TableRows"], (double)dbStats["TableSize"]);

                // this can be a string or array, how can we tell which it is
                JToken rows = results["Rows"];

                if (rows is JArray)
                {
                    // can pick one, or flatten array to a string
                    rowList = (JArray)rows;
                    foreach (var row in rowList)
                    {
                        LogStat ll = new LogStat((int)row["Count"], (int)row["Year"], (int)row["Month"]);
                        logList.Add(ll);
                    }
                }
            }
            else
            {
                MessageBox.Show("MySQL Log database not correctly setup.\r\nMake sure you are using MySQL (not SQLite)\r\nDo you have UseSqlLogs set to true?", "Remote Log Maintenance", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (System.Windows.Forms.Application.MessageLoop)
                {
                    // WinForms app
                    System.Windows.Forms.Application.Exit();
                }
                else
                {
                    // Console app
                    System.Environment.Exit(1);
                }
            }
            stats.DBStats = ds;
            stats.LogStats = logList;

            return stats;
        }
        public bool deleteRows(string rows)
        {
            string sendCommand = "http://" + conn.Server + "/" + "SQLLogger/deleteRows" + "?token=" + token + "&delete=(" + rows + ")";

            JObject results = Utils.GetHTTP(sendCommand);

            // this can be a string or null
            string status = (string)results["status"];
            if (status.Equals("200"))
            {
                if (results["token"] != null)
                    token = (string)results["token"];
            }
            return true;
        }
    }

    public class Response
    {
        [DataMember(Name = "status")]
        public string status { get; set; }
        [DataMember(Name = "response")]
        public string response { get; set; }
        [DataMember(Name = "token")]
        public string token { get; set; }
        [DataMember(Name = "rows")]
        public string rows { get; set; }
    }

}
