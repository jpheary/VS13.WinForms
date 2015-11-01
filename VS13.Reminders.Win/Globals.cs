using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VS13 {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }

    //Global application object
    public class App {
        //Members

        //Interface
        static App() { }
        private App() { }
        public static void ReportError(Exception ex,bool showMessage) {
            //Report an exception to the user
            try {
                string msg = ex.Message;
                if (ex.InnerException != null)  msg = ex.Message + "\n\n NOTE: " + ex.InnerException.Message;
                if (showMessage) MessageBox.Show(msg,"Reminders",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch (Exception) { }
        }
    }
}
