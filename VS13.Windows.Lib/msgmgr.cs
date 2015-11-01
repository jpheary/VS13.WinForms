using System;
using System.Collections;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace VS13.Windows {
	//
	public class MessageManager {
		//Members		
        private ToolStripStatusLabel mDisplay = null;
		private Queue mQue=null;
		private ManualResetEvent mEvent=null;
		private Thread mThread=null;
		private int mInterval=DEFAULT_MESSAGE_INTERVAL;
		private int mCleanupInterval=DEFAULT_CLEANUP_INTERVAL;

        private const int DEFAULT_QUE_SIZE = 10;
        private const int DEFAULT_MESSAGE_INTERVAL = 250;
        private const int DEFAULT_CLEANUP_INTERVAL = 3000;

        private delegate void MessageHandler(string message);
        private MessageHandler mMessageDelegate = null;
        private EventHandler mCleanupDelegate = null;
		
        //Interface
		public MessageManager(): this(null) {}
        public MessageManager(ToolStripStatusLabel display) : this(display,DEFAULT_MESSAGE_INTERVAL,DEFAULT_CLEANUP_INTERVAL) { }
        public MessageManager(ToolStripStatusLabel display,int messageInterval) : this(display,messageInterval,DEFAULT_CLEANUP_INTERVAL) { }
        public MessageManager(ToolStripStatusLabel display,int messageInterval,int cleanupInterval) {
			//Constructor
			try {
				//Set panel object
                this.mDisplay = display;
				this.mDisplay.Click += new System.EventHandler(onPanelClick);
				this.mQue = new Queue(DEFAULT_QUE_SIZE);
				this.mInterval = messageInterval;
				this.mCleanupInterval = cleanupInterval;
				this.mEvent = new ManualResetEvent(false);
                this.mMessageDelegate = new MessageHandler(onDisplay);
                this.mCleanupDelegate = new EventHandler(onCleanup);
				this.mThread = new Thread(new ThreadStart(displayMessages));
				this.mThread.IsBackground = true;
				this.mThread.Start();
			} 
			catch(Exception ex) { throw new ApplicationException(ex.Message, ex); }
		}
		~MessageManager() { if(this.mEvent != null) this.mEvent.Close(); }
		public void AddMessage(string message) { 
			try {
				//Add a message for display
                this.mQue.Enqueue(message);
				this.mEvent.Set();
			}
			catch(Exception ex) { throw new ApplicationException(ex.Message, ex); }
        }

        #region Local Services: onPanelClick(), displayMessages(), onDisplay(), onCleanup()
        private void onPanelClick(object Sender, EventArgs e) { if(this.mDisplay != null) this.mDisplay.Text = ""; }
        private void displayMessages() {
			//Event handler for status bar cleanup timer
			do {
				//Don't let this loop quit on an exception
				try {
					//Wait for a signal that a new message has arrived
					this.mEvent.WaitOne();
					this.mEvent.Reset();
					if(this.mDisplay != null) {
						//Display all new messages in the que
						while(this.mQue.Count > 0) {
							//Display next message in the panel and pause
                            this.mDisplay.GetCurrentParent().Invoke(this.mMessageDelegate,new object[] { this.mQue.Dequeue().ToString() });
							Thread.Sleep(this.mInterval);
						}
						
						//Pause longer on the last message, then clear it
						Thread.Sleep(this.mCleanupInterval);
                        this.mDisplay.GetCurrentParent().Invoke(this.mCleanupDelegate,new object[] { this,EventArgs.Empty });
					}
					else
						this.mQue.Clear();
				}
                catch(Exception ex) { throw new ApplicationException(ex.Message, ex); }
			} while(true);
		}
        private void onDisplay(string message) { this.mDisplay.Text = message; this.mDisplay.GetCurrentParent().Refresh(); }
        private void onCleanup(object sender, EventArgs e) { this.mDisplay.Text = ""; }
        #endregion
    }
}
