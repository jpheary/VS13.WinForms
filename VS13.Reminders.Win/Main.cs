using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VS13 {
    //
    public partial class frmMain:Form {
        //Members
        private ReminderService mReminders = null;

        //Interface
        public frmMain() {
            //Constructor
            try {
                InitializeComponent();
                this.mReminders = new ReminderService();
                this.mReminders.OpenItem += new ReminderEventHandler(OnOpenReminderItem);
                this.mReminders.ItemsChanged += new EventHandler(OnReminderItemsChanged);
            }
            catch (Exception ex) { App.ReportError(ex,false); }
        }
        private void OnFormLoad(object sender,EventArgs e) {
            //Event handler for form load event
            try {
                //Start the reminder service and refresh
                //TODO: What good are reminders if we fail to refresh the grid
                this.mReminders.Start();
                this.csRefresh.PerformClick();
            }
            catch (Exception ex) { App.ReportError(ex,false); }
        }
        private void OnFormClosing(object sender,FormClosingEventArgs e) {
            //Event handler for form closing eevent
            try {
                if (!e.Cancel) {
                    //Kill services
                    this.mReminders.Stop();
                }
            }
            catch (Exception ex) { App.ReportError(ex,false); }
        }
        private void OnGridSelectionChanged(object sender,EventArgs e) {
            //Event handler for grid row selected
            setUserServices();
        }
        private void OnItemClick(object sender,System.EventArgs e) {
            //Event handler for menu selection
            try {
                ToolStripItem item = (ToolStripItem)sender;
                switch (item.Name) {
                    case "csRefresh":
                        //Refresh issues
                        this.mIssues.Clear();
                        this.mIssues.Merge(DataGateway.GetIssues());

                        //Update reminder flags
                        for (int i = 0;i < this.dgvMain.Rows.Count;i++) {
                            int id = Convert.ToInt32(this.dgvMain.Rows[i].Cells["colID"].Value);
                            if (this.mReminders.HasReminder(id,Environment.UserName)) this.dgvMain.Rows[i].Cells["colReminder"].Value = this.mReminders.ReminderImage;
                        }
                        break;
                    case "csReminder":
                        this.mReminders.AddReminder(Convert.ToInt32(this.dgvMain.SelectedRows[0].Cells["colID"].Value),this.dgvMain.SelectedRows[0].Cells["colSubject"].Value.ToString(),Environment.UserName);
                        this.csRefresh.PerformClick();
                        break;
                    case "csClearFlag":
                        this.mReminders.RemoveReminder(Convert.ToInt32(this.dgvMain.SelectedRows[0].Cells["colID"].Value),Environment.UserName);
                        this.csRefresh.PerformClick();
                        break;
                }
            }
            catch (Exception ex) { App.ReportError(ex,true); }
            finally { setUserServices(); this.Cursor = Cursors.Default; }
        }
        private void setUserServices() {
            //Set user services
            try {
                this.csRefresh.Enabled = true;
                this.csReminder.Enabled = this.dgvMain.SelectedRows.Count > 0;
                this.csClearFlag.Enabled = this.dgvMain.SelectedRows.Count > 0 && this.dgvMain.SelectedRows[0].Cells["Reminder"].Value != null;
            }
            catch (Exception ex) { App.ReportError(ex,false); }
        }

        #region Reminders: OnReminderOpenItem(), OnReminderItemsChanged()
        private void OnOpenReminderItem(object source,ReminderEventArgs e) {
            //Event handler for Rmeminder OpenItem event
            try {
                //Select the row and scroll into view
                for (int i = 0;i < this.dgvMain.Rows.Count;i++) {
                    if (Convert.ToInt32(this.dgvMain.Rows[i].Cells["colID"].Value) == e.ID) {
                        this.dgvMain.Rows[i].Selected = true;
                        this.dgvMain.FirstDisplayedScrollingRowIndex = i;
                        this.dgvMain.Refresh();
                        break;
                    }
                }
            }
            catch (Exception ex) { App.ReportError(ex,false); }
        }
        private void OnReminderItemsChanged(object source,EventArgs e) {
            //Event handler for ItemChanged event
            try {
                //Update any cleared reminder flags
                this.csRefresh.PerformClick();
            }
            catch (Exception ex) { App.ReportError(ex,false); }
        }
        #endregion

    }
}
