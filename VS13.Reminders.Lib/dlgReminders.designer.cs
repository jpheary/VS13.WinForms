namespace VS13 {
    partial class dlgReminders {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnDismiss = new System.Windows.Forms.Button();
            this.btnSnooze = new System.Windows.Forms.Button();
            this.mOpenReminders = new VS13.RemindersDataset();
            this.btnOpenItem = new System.Windows.Forms.Button();
            this.btnDismissAll = new System.Windows.Forms.Button();
            this.lblSnooze = new System.Windows.Forms.Label();
            this.cboSnooze = new System.Windows.Forms.ComboBox();
            this.dgvReminders = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mOpenReminders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReminders)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDismiss
            // 
            this.btnDismiss.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDismiss.Location = new System.Drawing.Point(499, 177);
            this.btnDismiss.Name = "btnDismiss";
            this.btnDismiss.Size = new System.Drawing.Size(75, 23);
            this.btnDismiss.TabIndex = 6;
            this.btnDismiss.Text = "Dismiss";
            this.btnDismiss.UseVisualStyleBackColor = true;
            this.btnDismiss.Click += new System.EventHandler(this.OnButtonClick);
            // 
            // btnSnooze
            // 
            this.btnSnooze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSnooze.Location = new System.Drawing.Point(497, 232);
            this.btnSnooze.Name = "btnSnooze";
            this.btnSnooze.Size = new System.Drawing.Size(75, 23);
            this.btnSnooze.TabIndex = 5;
            this.btnSnooze.Text = "Snooze";
            this.btnSnooze.UseVisualStyleBackColor = true;
            this.btnSnooze.Click += new System.EventHandler(this.OnButtonClick);
            // 
            // mOpenReminders
            // 
            this.mOpenReminders.DataSetName = "RemindersDataset";
            this.mOpenReminders.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnOpenItem
            // 
            this.btnOpenItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenItem.Location = new System.Drawing.Point(418, 177);
            this.btnOpenItem.Name = "btnOpenItem";
            this.btnOpenItem.Size = new System.Drawing.Size(75, 23);
            this.btnOpenItem.TabIndex = 133;
            this.btnOpenItem.Text = "Open Item";
            this.btnOpenItem.UseVisualStyleBackColor = true;
            this.btnOpenItem.Click += new System.EventHandler(this.OnButtonClick);
            // 
            // btnDismissAll
            // 
            this.btnDismissAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDismissAll.Location = new System.Drawing.Point(10, 177);
            this.btnDismissAll.Name = "btnDismissAll";
            this.btnDismissAll.Size = new System.Drawing.Size(75, 23);
            this.btnDismissAll.TabIndex = 134;
            this.btnDismissAll.Text = "Dismiss All";
            this.btnDismissAll.UseVisualStyleBackColor = true;
            this.btnDismissAll.Click += new System.EventHandler(this.OnButtonClick);
            // 
            // lblSnooze
            // 
            this.lblSnooze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSnooze.Location = new System.Drawing.Point(10, 213);
            this.lblSnooze.Name = "lblSnooze";
            this.lblSnooze.Size = new System.Drawing.Size(200, 16);
            this.lblSnooze.TabIndex = 135;
            this.lblSnooze.Text = "Click Snooze to be reminded again in:";
            // 
            // cboSnooze
            // 
            this.cboSnooze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboSnooze.FormattingEnabled = true;
            this.cboSnooze.Items.AddRange(new object[] {
            "5 minutes",
            "10 minutes",
            "15 minutes",
            "30 minutes",
            "1 hour",
            "2 hours",
            "4 hours",
            "8 hours",
            "0.5 days",
            "1 day",
            "2 days",
            "3 days",
            "4 days",
            "1 week",
            "2 weeks"});
            this.cboSnooze.Location = new System.Drawing.Point(10, 234);
            this.cboSnooze.Name = "cboSnooze";
            this.cboSnooze.Size = new System.Drawing.Size(363, 21);
            this.cboSnooze.TabIndex = 136;
            this.cboSnooze.SelectionChangeCommitted += new System.EventHandler(this.OnValidateForm);
            // 
            // dgvReminders
            // 
            this.dgvReminders.AllowUserToAddRows = false;
            this.dgvReminders.AllowUserToDeleteRows = false;
            this.dgvReminders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReminders.AutoGenerateColumns = false;
            this.dgvReminders.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvReminders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReminders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colTime,
            this.colSubject,
            this.colMessage,
            this.colUserID});
            this.dgvReminders.DataMember = "ReminderTable";
            this.dgvReminders.DataSource = this.mOpenReminders;
            this.dgvReminders.Location = new System.Drawing.Point(10, 10);
            this.dgvReminders.MultiSelect = false;
            this.dgvReminders.Name = "dgvReminders";
            this.dgvReminders.ReadOnly = true;
            this.dgvReminders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReminders.Size = new System.Drawing.Size(564, 161);
            this.dgvReminders.TabIndex = 137;
            this.dgvReminders.SelectionChanged += new System.EventHandler(this.OnReminderSelected);
            // 
            // colID
            // 
            this.colID.DataPropertyName = "ID";
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 50;
            // 
            // colTime
            // 
            this.colTime.DataPropertyName = "Time";
            dataGridViewCellStyle1.Format = "MM/dd/yyyy HH:mm tt";
            this.colTime.DefaultCellStyle = dataGridViewCellStyle1;
            this.colTime.HeaderText = "Time";
            this.colTime.Name = "colTime";
            this.colTime.ReadOnly = true;
            this.colTime.Width = 125;
            // 
            // colSubject
            // 
            this.colSubject.DataPropertyName = "Subject";
            this.colSubject.HeaderText = "Subject";
            this.colSubject.Name = "colSubject";
            this.colSubject.ReadOnly = true;
            this.colSubject.Width = 150;
            // 
            // colMessage
            // 
            this.colMessage.DataPropertyName = "Message";
            this.colMessage.HeaderText = "Message";
            this.colMessage.Name = "colMessage";
            this.colMessage.ReadOnly = true;
            this.colMessage.Width = 250;
            // 
            // colUserID
            // 
            this.colUserID.DataPropertyName = "UserID";
            this.colUserID.HeaderText = "User";
            this.colUserID.Name = "colUserID";
            this.colUserID.ReadOnly = true;
            this.colUserID.Width = 50;
            // 
            // dlgReminders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.dgvReminders);
            this.Controls.Add(this.cboSnooze);
            this.Controls.Add(this.lblSnooze);
            this.Controls.Add(this.btnDismissAll);
            this.Controls.Add(this.btnOpenItem);
            this.Controls.Add(this.btnDismiss);
            this.Controls.Add(this.btnSnooze);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "dlgReminders";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VS13 Reminders";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.Load += new System.EventHandler(this.OnFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.mOpenReminders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReminders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDismiss;
        private System.Windows.Forms.Button btnSnooze;
        private System.Windows.Forms.Button btnOpenItem;
        private System.Windows.Forms.Button btnDismissAll;
        private System.Windows.Forms.Label lblSnooze;
        private System.Windows.Forms.ComboBox cboSnooze;
        private RemindersDataset mOpenReminders;
        private System.Windows.Forms.DataGridView dgvReminders;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserID;
    }
}