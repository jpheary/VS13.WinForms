using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;

namespace VS13 {
	//
	public class ReminderService {
		//Members
        private RemindersDataset mReminders=null;
        private dlgReminders mDialog=null;

        private System.Windows.Forms.Timer mTimer=null;
        private BackgroundWorker mWorker=null;
        
        //Interface
        public ReminderService() { 
            //Constructor
            this.mReminders = new RemindersDataset();
            this.mDialog = new dlgReminders(this);

            this.mTimer = new System.Windows.Forms.Timer();
            this.mTimer.Interval = 15000;
            this.mTimer.Tick += new EventHandler(OnTick);
            this.mWorker = new BackgroundWorker();
            this.mWorker.DoWork += new DoWorkEventHandler(OnDoWork);
            this.mWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(OnRunWorkerCompleted);
        }
        public event ReminderEventHandler OpenItem = null;
        public event EventHandler ItemsChanged = null;
        public void Start() {
            //Load previous reminders from user cache and start the reminder service
            if (global::VS13.Properties.Settings.Default.Reminders.Trim().Length > 0) {
                MemoryStream ms = new MemoryStream(Encoding.ASCII.GetBytes(global::VS13.Properties.Settings.Default.Reminders));
                this.mReminders.ReadXml(ms,XmlReadMode.ReadSchema);
            }
            this.mTimer.Start();
        }
        public void Stop() {
            //Stop the remineder service and save current reminders to user cache
            this.mTimer.Stop();
            MemoryStream ms = new MemoryStream();
            this.mReminders.WriteXml(ms,XmlWriteMode.WriteSchema);
            global::VS13.Properties.Settings.Default.Reminders = Encoding.ASCII.GetString(ms.ToArray());
            global::VS13.Properties.Settings.Default.Save();
        }
        public void AddReminder(int id,string subject, string userID) {
            //Prompt user for a new reminder or open existing
            RemindersDataset.ReminderTableRow reminder=null;
            dlgReminder dlg=null;
            if(HasReminder(id,userID)) {
                reminder = (RemindersDataset.ReminderTableRow)this.mReminders.ReminderTable.Select("ID=" + id + " AND UserID='" + userID + "'")[0];
                dlg = new dlgReminder(reminder);
                dlg.ShowDialog();
            }
            else {
                reminder = this.mReminders.ReminderTable.NewReminderTableRow();
                reminder.ID = id;
                reminder.Subject = subject;
                reminder.UserID = userID;
                reminder.Message = "";
                reminder.Time = DateTime.Now;
                dlg = new dlgReminder(reminder);
                if(dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                    lock(this.mReminders) {
                        this.mReminders.ReminderTable.AddReminderTableRow(id,subject,userID,reminder.Time,reminder.Message);
                    }
                }
            }
        }
        public void AddReminder(int id,string subject,string userID, DateTime time, string message) {
            //Add a new reminder
            lock(this.mReminders) {
                this.mReminders.ReminderTable.AddReminderTableRow(id,subject,userID,time,message);
            }
        }
        public void UpdateReminder(int id,string userID,DateTime time) {
            //Update an existing reminder
            lock(this.mReminders) {
                RemindersDataset.ReminderTableRow reminder = (RemindersDataset.ReminderTableRow)this.mReminders.ReminderTable.Select("ID=" + id + " AND UserID='" + userID + "'")[0];
                reminder.Time = time;
            }
        }
        public void RemoveReminder(int id,string userID) {
            //Remove an existing reminder
            lock(this.mReminders) {
                DataRow[] rows = this.mReminders.ReminderTable.Select("ID=" + id + " AND UserID='" + userID + "'");
                for(int i=0;i<rows.Length;i++) rows[i].Delete();
            }

            //Notify client that reminders changed
            if(this.ItemsChanged != null) this.ItemsChanged(this, new EventArgs());
        }
        public bool HasReminder(int id,string userID) {
            //Return true if a reminder exists
            bool has=false;
            lock(this.mReminders) {
                has = this.mReminders.ReminderTable.Select("ID=" + id + " AND UserID='" + userID + "'").Length > 0;
            }
            return has;
        }
        public void OpenReminderItem(int id,string message) {
            //Notify client to open the reminder item
            if(this.OpenItem != null) this.OpenItem(this,new ReminderEventArgs(id,message));
        }
        public Bitmap ReminderImage { get { return global::VS13.Properties.Resources.flag_red;  } }

        private void OnTick(object sender,EventArgs e) {
            //Event handler for timer tick event
            try { if(!this.mWorker.IsBusy) this.mWorker.RunWorkerAsync(); }
            catch { }
        }
        private void OnDoWork(object sender,DoWorkEventArgs e) {
            //Event handler for background worker thread DoWork event; runs on background thread
            try {
                //Find reminders that are ready to be published; marshall to main thread
                RemindersDataset reminders = new RemindersDataset();
                lock(this.mReminders) {
                    DataRow[] rows = this.mReminders.ReminderTable.Select("Time<='" + DateTime.Now.ToString() + "'");
                    for(int i=0;i<rows.Length;i++) reminders.ReminderTable.ImportRow(rows[i]);
                }
                e.Result = reminders;
            } 
            catch { }
        }
        private void OnRunWorkerCompleted(object sender,RunWorkerCompletedEventArgs e) {
            //Event handler for worker thread completed DoWork (this is on the main thread)
            try {
                //Notify user of open reminders
                if(e.Error == null) {
                    RemindersDataset reminders = (RemindersDataset)e.Result;
                    if(reminders != null && reminders.ReminderTable.Rows.Count > 0) {
                        for(int i=0;i<reminders.ReminderTable.Rows.Count;i++) {
                            int id = reminders.ReminderTable[i].ID;
                            string userID = reminders.ReminderTable[i].UserID;
                            DataRow[] rows = this.mDialog.OpenReminders.ReminderTable.Select("ID=" + id + " AND UserID='" + userID + "'");
                            if(rows.Length == 0) this.mDialog.OpenReminders.ReminderTable.ImportRow(reminders.ReminderTable[i]);
                        }
                        this.mDialog.Show();
                    }
                }
            }
            catch { }
        }
    }

    public delegate void ReminderEventHandler(object source,ReminderEventArgs e);
    public class ReminderEventArgs:EventArgs {
        private int _id=0;
        private string _message;
        public ReminderEventArgs(int id,string message) {
            //Constructor
            this._id = id;
            this._message = message;
        }
        public int ID { get { return this._id; } set { this._id = value; } }
        public string Message { get { return this._message; } set { this._message = value; } }
    }
}