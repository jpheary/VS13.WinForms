using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VS13 {
    //
    public partial class dlgReminder:Form {
        //Members
        RemindersDataset.ReminderTableRow mReminder=null;

        //Interface
        public dlgReminder(RemindersDataset.ReminderTableRow reminder) {
            //Constructor
            try { 
                InitializeComponent();
                this.mReminder = reminder;
            }
            catch (Exception ex) { MessageBox.Show(this,ex.Message,"Reminders",MessageBoxButtons.OK,MessageBoxIcon.Error); }
        }

        private void OnFormLoad(object sender,EventArgs e) {
            //Form load event handler
            this.Cursor = Cursors.WaitCursor;
            try {
                this.dtpDate.MaxDate = DateTime.Now.AddDays(14);
                this.txtMessage.Text = this.mReminder.Message;
                this.dtpDate.MinDate = this.dtpDate.Value = this.mReminder.Time;
                this.dtpTime.Value = this.mReminder.Time;
            }
            catch(Exception ex) { MessageBox.Show(this, ex.Message, "Reminders", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { OnValidateForm(null, EventArgs.Empty); this.Cursor = Cursors.Default; }
        }
        private void OnValidateForm(object sender,EventArgs e) {
            //Event handler for control value changes
            try {
                this.btnCancel.Enabled = true;
                this.btnOk.Enabled = true;
            }
            catch(Exception ex) { MessageBox.Show(this, ex.Message, "Reminders", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
        private void OnButtonClick(object sender,EventArgs e) {
            //Button click event handler
            try {
                Button btn = (Button)sender;
                switch(btn.Name) {
                    case "btnCancel":
                        this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                        break;
                    case "btnOk":
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                        DateTime date = this.dtpDate.Value;
                        DateTime time = this.dtpTime.Value;
                        this.mReminder.Message = this.txtMessage.Text;
                        this.mReminder.Time = new DateTime(date.Year,date.Month,date.Day,time.Hour,time.Minute,0);
                        break;
                }
            }
            catch(Exception ex) { MessageBox.Show(this, ex.Message, "Reminders", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
