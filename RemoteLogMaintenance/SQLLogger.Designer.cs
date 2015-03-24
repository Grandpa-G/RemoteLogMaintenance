namespace RemoteLogMaintenance
{
    partial class SQLLogger
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SQLLogger));
            this.dataListLog = new System.Windows.Forms.DataGridView();
            this.dataSelectRow = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataLogLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCaller = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.chkSelectAll = new System.Windows.Forms.CheckBox();
            this.txtSearchMessage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtStartSearch = new System.Windows.Forms.DateTimePicker();
            this.dtEndSearch = new System.Windows.Forms.DateTimePicker();
            this.searchLog = new System.Windows.Forms.Button();
            this.lblRowCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRowLimit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDeleteSelected = new System.Windows.Forms.Button();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.listStats = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblDatabaseSize = new System.Windows.Forms.Label();
            this.lblLogSize = new System.Windows.Forms.Label();
            this.btnSaveAndDelete = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.clearSearch = new System.Windows.Forms.Button();
            this.refreshLog = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataListLog)).BeginInit();
            this.SuspendLayout();
            // 
            // dataListLog
            // 
            this.dataListLog.AllowUserToAddRows = false;
            this.dataListLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataSelectRow,
            this.dataID,
            this.dataDateTime,
            this.dataLogLevel,
            this.dataCaller,
            this.dataMessage});
            this.dataListLog.Location = new System.Drawing.Point(21, 91);
            this.dataListLog.Name = "dataListLog";
            this.dataListLog.RowHeadersVisible = false;
            this.dataListLog.Size = new System.Drawing.Size(731, 473);
            this.dataListLog.TabIndex = 0;
            this.dataListLog.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListLog_CellClick);
            // 
            // dataSelectRow
            // 
            this.dataSelectRow.HeaderText = "";
            this.dataSelectRow.Name = "dataSelectRow";
            this.dataSelectRow.Width = 20;
            // 
            // dataID
            // 
            this.dataID.HeaderText = "ID";
            this.dataID.Name = "dataID";
            this.dataID.ReadOnly = true;
            this.dataID.Visible = false;
            this.dataID.Width = 50;
            // 
            // dataDateTime
            // 
            this.dataDateTime.HeaderText = "Date Time";
            this.dataDateTime.Name = "dataDateTime";
            this.dataDateTime.ReadOnly = true;
            this.dataDateTime.Width = 130;
            // 
            // dataLogLevel
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataLogLevel.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataLogLevel.HeaderText = "Level";
            this.dataLogLevel.Name = "dataLogLevel";
            this.dataLogLevel.ReadOnly = true;
            this.dataLogLevel.Width = 40;
            // 
            // dataCaller
            // 
            this.dataCaller.HeaderText = "Caller";
            this.dataCaller.Name = "dataCaller";
            this.dataCaller.ReadOnly = true;
            // 
            // dataMessage
            // 
            this.dataMessage.HeaderText = "Message";
            this.dataMessage.Name = "dataMessage";
            this.dataMessage.ReadOnly = true;
            this.dataMessage.Width = 400;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Log Entries";
            // 
            // chkSelectAll
            // 
            this.chkSelectAll.AutoSize = true;
            this.chkSelectAll.Location = new System.Drawing.Point(27, 71);
            this.chkSelectAll.Name = "chkSelectAll";
            this.chkSelectAll.Size = new System.Drawing.Size(70, 17);
            this.chkSelectAll.TabIndex = 3;
            this.chkSelectAll.Text = "Select All";
            this.chkSelectAll.UseVisualStyleBackColor = true;
            this.chkSelectAll.CheckedChanged += new System.EventHandler(this.chkSelectAll_CheckedChanged);
            // 
            // txtSearchMessage
            // 
            this.txtSearchMessage.Location = new System.Drawing.Point(807, 53);
            this.txtSearchMessage.Name = "txtSearchMessage";
            this.txtSearchMessage.Size = new System.Drawing.Size(178, 20);
            this.txtSearchMessage.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(709, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Message Contains";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(774, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Start";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(777, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "End";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtStartSearch
            // 
            this.dtStartSearch.Location = new System.Drawing.Point(807, 91);
            this.dtStartSearch.MinDate = new System.DateTime(2015, 3, 1, 0, 0, 0, 0);
            this.dtStartSearch.Name = "dtStartSearch";
            this.dtStartSearch.ShowCheckBox = true;
            this.dtStartSearch.Size = new System.Drawing.Size(161, 20);
            this.dtStartSearch.TabIndex = 10;
            this.dtStartSearch.ValueChanged += new System.EventHandler(this.dtStartSearch_ValueChanged);
            // 
            // dtEndSearch
            // 
            this.dtEndSearch.Location = new System.Drawing.Point(807, 133);
            this.dtEndSearch.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dtEndSearch.Name = "dtEndSearch";
            this.dtEndSearch.ShowCheckBox = true;
            this.dtEndSearch.Size = new System.Drawing.Size(161, 20);
            this.dtEndSearch.TabIndex = 11;
            this.dtEndSearch.Value = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            // 
            // searchLog
            // 
            this.searchLog.Location = new System.Drawing.Point(816, 200);
            this.searchLog.Name = "searchLog";
            this.searchLog.Size = new System.Drawing.Size(75, 23);
            this.searchLog.TabIndex = 12;
            this.searchLog.Text = "Search";
            this.searchLog.UseVisualStyleBackColor = true;
            this.searchLog.Click += new System.EventHandler(this.searchLog_Click);
            // 
            // lblRowCount
            // 
            this.lblRowCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRowCount.Location = new System.Drawing.Point(410, 64);
            this.lblRowCount.Name = "lblRowCount";
            this.lblRowCount.Size = new System.Drawing.Size(158, 24);
            this.lblRowCount.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(775, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Limit";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRowLimit
            // 
            this.txtRowLimit.Location = new System.Drawing.Point(807, 171);
            this.txtRowLimit.MaxLength = 5;
            this.txtRowLimit.Name = "txtRowLimit";
            this.txtRowLimit.Size = new System.Drawing.Size(60, 20);
            this.txtRowLimit.TabIndex = 16;
            this.txtRowLimit.Text = "200";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(830, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "Search Criteria";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(833, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 24);
            this.label7.TabIndex = 18;
            this.label7.Text = "Actions";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(873, 386);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 24);
            this.label8.TabIndex = 19;
            this.label8.Text = "Stats";
            // 
            // btnDeleteSelected
            // 
            this.btnDeleteSelected.Location = new System.Drawing.Point(816, 285);
            this.btnDeleteSelected.Name = "btnDeleteSelected";
            this.btnDeleteSelected.Size = new System.Drawing.Size(107, 23);
            this.btnDeleteSelected.TabIndex = 20;
            this.btnDeleteSelected.Text = "Delete Selected";
            this.btnDeleteSelected.UseVisualStyleBackColor = true;
            this.btnDeleteSelected.Click += new System.EventHandler(this.btnDeleteSelected_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(816, 315);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(107, 23);
            this.btnSaveFile.TabIndex = 21;
            this.btnSaveFile.Text = "Export Selected";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // listStats
            // 
            this.listStats.BackColor = System.Drawing.Color.AliceBlue;
            this.listStats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listStats.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listStats.GridLines = true;
            this.listStats.Location = new System.Drawing.Point(778, 457);
            this.listStats.Name = "listStats";
            this.listStats.Size = new System.Drawing.Size(238, 107);
            this.listStats.TabIndex = 23;
            this.listStats.UseCompatibleStateImageBehavior = false;
            this.listStats.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Year";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "month";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 50;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Count";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 50;
            // 
            // lblDatabaseSize
            // 
            this.lblDatabaseSize.Location = new System.Drawing.Point(778, 417);
            this.lblDatabaseSize.Name = "lblDatabaseSize";
            this.lblDatabaseSize.Size = new System.Drawing.Size(229, 13);
            this.lblDatabaseSize.TabIndex = 24;
            // 
            // lblLogSize
            // 
            this.lblLogSize.Location = new System.Drawing.Point(778, 439);
            this.lblLogSize.Name = "lblLogSize";
            this.lblLogSize.Size = new System.Drawing.Size(229, 13);
            this.lblLogSize.TabIndex = 25;
            // 
            // btnSaveAndDelete
            // 
            this.btnSaveAndDelete.Location = new System.Drawing.Point(798, 345);
            this.btnSaveAndDelete.Name = "btnSaveAndDelete";
            this.btnSaveAndDelete.Size = new System.Drawing.Size(142, 23);
            this.btnSaveAndDelete.TabIndex = 26;
            this.btnSaveAndDelete.Text = "Export && Delete Selected";
            this.btnSaveAndDelete.UseVisualStyleBackColor = true;
            this.btnSaveAndDelete.Click += new System.EventHandler(this.btnSaveAndDelete_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(73, 27);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(58, 25);
            this.btnSettings.TabIndex = 27;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // clearSearch
            // 
            this.clearSearch.Location = new System.Drawing.Point(914, 198);
            this.clearSearch.Name = "clearSearch";
            this.clearSearch.Size = new System.Drawing.Size(25, 25);
            this.clearSearch.TabIndex = 5;
            this.clearSearch.UseVisualStyleBackColor = true;
            this.clearSearch.Click += new System.EventHandler(this.clearSearch_Click);
            // 
            // refreshLog
            // 
            this.refreshLog.Image = global::RemoteLogMaintenance.Properties.Resources.refresh;
            this.refreshLog.Location = new System.Drawing.Point(21, 27);
            this.refreshLog.Name = "refreshLog";
            this.refreshLog.Size = new System.Drawing.Size(29, 29);
            this.refreshLog.TabIndex = 2;
            this.refreshLog.UseVisualStyleBackColor = true;
            this.refreshLog.Click += new System.EventHandler(this.refreshLog_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.Location = new System.Drawing.Point(781, 569);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(235, 15);
            this.lblVersion.TabIndex = 28;
            this.lblVersion.Text = "label9";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SQLLogger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 586);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnSaveAndDelete);
            this.Controls.Add(this.lblLogSize);
            this.Controls.Add(this.lblDatabaseSize);
            this.Controls.Add(this.listStats);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.btnDeleteSelected);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtRowLimit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblRowCount);
            this.Controls.Add(this.searchLog);
            this.Controls.Add(this.dtEndSearch);
            this.Controls.Add(this.dtStartSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearchMessage);
            this.Controls.Add(this.clearSearch);
            this.Controls.Add(this.chkSelectAll);
            this.Controls.Add(this.refreshLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataListLog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SQLLogger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage MySql Logs";
            ((System.ComponentModel.ISupportInitialize)(this.dataListLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataListLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button refreshLog;
        private System.Windows.Forms.CheckBox chkSelectAll;
        private System.Windows.Forms.Button clearSearch;
        private System.Windows.Forms.TextBox txtSearchMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtStartSearch;
        private System.Windows.Forms.DateTimePicker dtEndSearch;
        private System.Windows.Forms.Button searchLog;
        private System.Windows.Forms.Label lblRowCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRowLimit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDeleteSelected;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataSelectRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataLogLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCaller;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataMessage;
        private System.Windows.Forms.ListView listStats;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label lblDatabaseSize;
        private System.Windows.Forms.Label lblLogSize;
        private System.Windows.Forms.Button btnSaveAndDelete;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

