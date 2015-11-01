using System;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace VS13.Windows {
	//
	public class Splash {
		//Class Members
        private static string _Title = "ApplicationName";
        private static string _Version = "4.5.0.0";
        private static string _Copyright = "_Copyright 2014 - " + DateTime.Today.Year + " jpHeary";
        private static dlgSplash _dlgSplash = null;
        private static EventHandler OnClose = new EventHandler(close);
				
		//Interface
        static Splash() { }
        private Splash() { }
		public static void Start(string title, Assembly assembly, string copyright) {
			//
			try {
				//Caapture splash attributes
				_Title = title;
				Version version = assembly.GetName().Version;
                _Version = version.Major + "." + version.Minor + "." + version.Build + "." + version.Revision;
				_Copyright = copyright;
				
				//Launch splash dialog on an independent thread
				Thread t = new Thread(new ThreadStart(Splash.show));
				t.IsBackground = true;
				t.Start();
				Thread.Sleep(500);
			}
            catch(Exception ex) { throw new ApplicationException(ex.Message,ex); }
        }
		public static void Close() {
			//Closes the splash dialog
			try {
                if(_dlgSplash != null && !_dlgSplash.IsDisposed) _dlgSplash.BeginInvoke(OnClose);
			}
            catch { }
        }
        private static void show() {
			//This is the actual thread procedure. This method runs on a background thread
			try {
				//Show the splash screen
				_dlgSplash = new dlgSplash(Splash._Title, Splash._Version, Splash._Copyright);
				_dlgSplash.ShowDialog();
			} 
			catch(Exception) { }
		}
        private static void close(object sender,EventArgs e) {
            //This is the actual thread procedure. This method runs on a background thread
            try {
                _dlgSplash.Close();
            }
            catch(Exception) { }
        }
    }
}
