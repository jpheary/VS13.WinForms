using System;
using System.Diagnostics;
using System.Reflection;

namespace VS13.Windows {
	//
	public class AppServices {
		public AppServices() { }

        /// <summary>
        /// Call this Win32 function when you need access to raw command line string.
        /// </summary>
        /// <returns>System.IntPtr</returns>
        [System.Runtime.InteropServices.DllImport("kernel32.dll",CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern System.IntPtr GetCommandLine();
        
        /// <summary>
		/// Call this Win32 function to bring an existing window to foreground.
		/// </summary>
		/// <param name="handle"></param>
        /// <returns>bool</returns>
		[System.Runtime.InteropServices.DllImport("user32.dll",EntryPoint="SetForegroundWindow", CallingConvention= System.Runtime.InteropServices.CallingConvention.StdCall, CharSet=System.Runtime.InteropServices.CharSet.Unicode, SetLastError=true)]
		public static extern bool SetForegroundWindow(IntPtr handle );

		/// <summary>
        /// Call this Win32 function to show existing Application if it's minimized.
		/// </summary>
		/// <param name="handle"></param>
		/// <param name="nCmd"></param>
        /// <returns>bool</returns>
		[System.Runtime.InteropServices.DllImport("user32.dll",EntryPoint="ShowWindow", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall, CharSet=System.Runtime.InteropServices.CharSet.Unicode, SetLastError=true)]
		public static extern bool ShowWindow(IntPtr handle , Int32 nCmd );

		/// <summary>
		/// Returns running instance of the existing app. Process object will be null if it's not running.
		/// </summary>
		/// <returns>Process</returns>
		public static Process RunningInstance() { 
			//
			Process current = Process.GetCurrentProcess(); 
			Process[] processes = Process.GetProcessesByName (current.ProcessName); 
			
			//Loop through the running processes in with the same name 
			foreach (Process process in processes) { 
				//Ignore the current process 
				if (process.Id != current.Id) { 
					//Make sure that the process is running from the exe file
					if (process.ProcessName == current.ProcessName) {  
						//Return the other process instance.  
						return process;
					}  
				}  
			} 
			//No other instance was found, return null.  
			return null;  
		} 
		/// <summary>
		/// This method will check for existing app based on the main window title because process runs under IEExe.exe process when run using URL.
		/// </summary>
		/// <param name="mainWindowTitle"></param>
		/// <returns>Process</returns>
		public static Process RunningInstance(string mainWindowTitle) { 
			Process current = Process.GetCurrentProcess(); 
			Process[] processes = Process.GetProcessesByName (current.ProcessName); 
			
			//Loop through the running processes in with the same name 
			foreach (Process process in processes) { 
				//Ignore the current process 
				if(process.Id != current.Id) { 
					//Make sure that the process does not have the same Main Window title
					if(process.MainWindowTitle.ToUpper() == mainWindowTitle.ToUpper()) {  
						//Return the other process instance.  
						return process;
					}
					if(process.MainWindowTitle.Length >= mainWindowTitle.Length) { 
						if(process.MainWindowTitle.Substring(0, mainWindowTitle.Length).ToUpper() == mainWindowTitle.ToUpper()) { 
							//Return the other process instance.  
							return process;
						}
					}
				}  
			} 
			//No other instance was found, return null.  
			return null;  
		} 
	}
}
