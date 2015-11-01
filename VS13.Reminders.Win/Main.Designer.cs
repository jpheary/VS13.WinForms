namespace VS13 {
    partial class frmMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            this.components = new System.ComponentModel.Container();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.csMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.csRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.csSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.csReminder = new System.Windows.Forms.ToolStripMenuItem();
            this.csClearFlag = new System.Windows.Forms.ToolStripMenuItem();
            this.mIssues = new VS13.IssueDataset();
            this.colReminder = new System.Windows.Forms.DataGridViewImageColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.csMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mIssues)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.AutoGenerateColumns = false;
            this.dgvMain.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colReminder,
            this.colID,
            this.colSubject,
            this.colCompany,
            this.colContact,
            this.colComment});
            this.dgvMain.ContextMenuStrip = this.csMain;
            this.dgvMain.DataMember = "IssueTable";
            this.dgvMain.DataSource = this.mIssues;
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Location = new System.Drawing.Point(0, 0);
            this.dgvMain.MultiSelect = false;
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(641, 240);
            this.dgvMain.TabIndex = 138;
            this.dgvMain.SelectionChanged += new System.EventHandler(this.OnGridSelectionChanged);
            // 
            // csMain
            // 
            this.csMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.csRefresh,
            this.csSep1,
            this.csReminder,
            this.csClearFlag});
            this.csMain.Name = "csMain";
            this.csMain.Size = new System.Drawing.Size(160, 76);
            // 
            // csRefresh
            // 
            this.csRefresh.Name = "csRefresh";
            this.csRefresh.Size = new System.Drawing.Size(159, 22);
            this.csRefresh.Text = "Refresh";
            this.csRefresh.Click += new System.EventHandler(this.OnItemClick);
            // 
            // csSep1
            // 
            this.csSep1.Name = "csSep1";
            this.csSep1.Size = new System.Drawing.Size(156, 6);
            // 
            // csReminder
            // 
            this.csReminder.Name = "csReminder";
            this.csReminder.Size = new System.Drawing.Size(159, 22);
            this.csReminder.Text = "Add Reminder...";
            this.csReminder.Click += new System.EventHandler(this.OnItemClick);
            // 
            // csClearFlag
            // 
            this.csClearFlag.Name = "csClearFlag";
            this.csClearFlag.Size = new System.Drawing.Size(159, 22);
            this.csClearFlag.Text = "Clear Flag";
            this.csClearFlag.Click += new System.EventHandler(this.OnItemClick);
            // 
            // mIssues
            // 
            this.mIssues.DataSetName = "IssueDataset";
            this.mIssues.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colReminder
            // 
            this.colReminder.Frozen = true;
            this.colReminder.HeaderText = "";
            this.colReminder.Name = "colReminder";
            this.colReminder.ReadOnly = true;
            this.colReminder.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colReminder.Width = 20;
            // 
            // colID
            // 
            this.colID.DataPropertyName = "ID";
            this.colID.Frozen = true;
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 50;
            // 
            // colSubject
            // 
            this.colSubject.DataPropertyName = "Subject";
            this.colSubject.HeaderText = "Subject";
            this.colSubject.Name = "colSubject";
            this.colSubject.ReadOnly = true;
            // 
            // colCompany
            // 
            this.colCompany.DataPropertyName = "Company";
            this.colCompany.HeaderText = "Company";
            this.colCompany.Name = "colCompany";
            this.colCompany.ReadOnly = true;
            // 
            // colContact
            // 
            this.colContact.DataPropertyName = "Contact";
            this.colContact.HeaderText = "Contact";
            this.colContact.Name = "colContact";
            this.colContact.ReadOnly = true;
            this.colContact.Width = 75;
            // 
            // colComment
            // 
            this.colComment.DataPropertyName = "Comment";
            this.colComment.HeaderText = "Comment";
            this.colComment.Name = "colComment";
            this.colComment.ReadOnly = true;
            this.colComment.Width = 250;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 240);
            this.Controls.Add(this.dgvMain);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reminders";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.Load += new System.EventHandler(this.OnFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.csMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mIssues)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.ContextMenuStrip csMain;
        private System.Windows.Forms.ToolStripMenuItem csRefresh;
        private System.Windows.Forms.ToolStripSeparator csSep1;
        private System.Windows.Forms.ToolStripMenuItem csReminder;
        private System.Windows.Forms.ToolStripMenuItem csClearFlag;
        private IssueDataset mIssues;
        private System.Windows.Forms.DataGridViewImageColumn colReminder;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComment;
    }
}

