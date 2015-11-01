using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Threading;

namespace VS13 {
	//
	public class ActiveGateway {
		//Members
        private static DataSet _Data = null;                            //Cached data available to the UI AND ALWAYS on the UI thread (has to be)
        private static Monitor _Monitor=null;                           //Fetches data on a background thread

        public static event EventHandler GatewayCacheUpdated = null;    //Notify the UI to pull the latest data update
		
		//Interface
        static ActiveGateway() {
            _Data = new DataSet();
            _Monitor = new Monitor(7500);
            _Monitor.DataUpdate += new DataEventHandler(OnDataUpdate);
        }
        private ActiveGateway() { }
        public static DataSet Data { get { return _Data; } }
        public static void Start() { _Monitor.Start(); }
        public static void Stop() { _Monitor.Stop(); }
        public static void Refresh() {
            //Refresh the data cache
            try {
                //Lock the shared resource from background thead updates from the Monitor
                DataSet ds = GetData();
                if (ds != null) { 
                    lock (_Data) {
                        _Data.Clear();
                        _Data.Merge(ds);
                    }
                }
            }
            catch(Exception ex) { throw new ApplicationException(ex.Message,ex); }
            finally { if(GatewayCacheUpdated != null) GatewayCacheUpdated(null,EventArgs.Empty); }
        }
        private static DataSet GetData() {
            //Get the latest data
            //This method is called by the main thread on Refresh() and by the background thread by the Monitor::OnTick() handler
            DataSet ds=null;
            try {
                //Create some fake data
                //Normally, this would be a call to a backend resource (i.e. database, web service)
                ds = new DataSet();
                ds.Tables.Add("DataTable");
                ds.Tables["DataTable"].Columns.Add("Time");
                ds.Tables["DataTable"].Columns.Add("GetDataThreadId");
                ds.Tables["DataTable"].Columns.Add("OnDoWorkThreadId");
                ds.Tables["DataTable"].Columns.Add("OnRunWorkerCompletedThreadId");

                DataRow row = ds.Tables["DataTable"].NewRow();
                row["Time"] = DateTime.Now.ToLongTimeString();
                row["GetDataThreadId"] = Thread.CurrentThread.ManagedThreadId.ToString();
                ds.Tables["DataTable"].Rows.Add(row);
            }
            catch(Exception ex) { throw new ApplicationException(ex.Message, ex); }
            return ds;
        }
        static void OnDataUpdate(object source,DataEventArgs e) {
            //Event handler for monitor data update event
            //Let the gateway decide what to do with the data
            try {
                //On the main thread (so do I really need a lock??)
                //Lock the shared resource to block manual refresh from UI
                DataSet ds = (DataSet)e.Data;
                if (ds != null) {
                    lock (_Data) {
                        _Data.Clear();
                        _Data.Merge(ds);
                    }
                }
            }
            catch(Exception ex) { throw new ApplicationException(ex.Message, ex); }
            finally { if(GatewayCacheUpdated != null) GatewayCacheUpdated(null, EventArgs.Empty); }
        }


        internal class Monitor {
            //Members
            private BackgroundWorker mWorker = null;                //Worker to read data on a background thread
            private System.Windows.Forms.Timer mTimer = null;       //Refresh rate
            private int mSleepTimeout = SLEEP_DEFAULT;

            public const int SLEEP_DEFAULT = 15000;
            public event DataEventHandler DataUpdate = null;

            //Interface
            public Monitor(int sleepTimeout) {
                //
                this.mSleepTimeout = sleepTimeout > SLEEP_DEFAULT ? sleepTimeout : SLEEP_DEFAULT;
                this.mWorker = new BackgroundWorker();
                this.mWorker.DoWork += new DoWorkEventHandler(OnDoWork);
                this.mWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(OnRunWorkerCompleted);
                this.mTimer = new System.Windows.Forms.Timer();
                this.mTimer.Interval = sleepTimeout;
                this.mTimer.Tick += new EventHandler(OnTick);
            }
            public void Start() { this.mTimer.Start(); }
            public void Stop() { this.mTimer.Stop(); }
            private void OnTick(object sender,EventArgs e) { this.mWorker.RunWorkerAsync(); }
            private void OnDoWork(object sender,DoWorkEventArgs e) {
                //Asynchronous call from the worker with each tick of the timer
                //Tell the gateway to go read the latest data on this background thread
                //Then marshall back to the main thread
                DataSet ds = ActiveGateway.GetData();
                if (ds != null && ds.Tables["DataTable"] != null && ds.Tables["DataTable"].Rows.Count > 0)
                    ds.Tables["DataTable"].Rows[0]["OnDoWorkThreadId"] = Thread.CurrentThread.ManagedThreadId.ToString();
                e.Result = ds;
            }
            private void OnRunWorkerCompleted(object sender,RunWorkerCompletedEventArgs e) {
                //Marshalled back to the main thread
                DataSet ds = (DataSet)e.Result;
                if (ds != null && ds.Tables["DataTable"] != null && ds.Tables["DataTable"].Rows.Count > 0)
                    ds.Tables["DataTable"].Rows[0]["OnRunWorkerCompletedThreadId"] = Thread.CurrentThread.ManagedThreadId.ToString();
                
                //Notify the gateway to update the cache
                if (this.DataUpdate != null) this.DataUpdate(this,new DataEventArgs(ds));
            }
        }
    }

    public delegate void DataEventHandler(object source,DataEventArgs e);
    public class DataEventArgs:EventArgs {
        private object _data = null;
        public DataEventArgs(object data) { this._data = data; }
        public object Data { get { return this._data; } set { this._data = value; } }
    }
}