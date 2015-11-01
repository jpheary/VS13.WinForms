using System;
using System.Data;
using System.Reflection;

namespace VS13 {
    //
	namespace Windows {
		//Global application object template
		public abstract class AppBase {
			//Members
			public static Assembly _Assy=Assembly.GetEntryAssembly();
						
			//Interface
			static AppBase() { }
			#region Assembly Attributes
			public static string Title { 
				get {
					object[] o = _Assy.GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
					AssemblyTitleAttribute att = (AssemblyTitleAttribute)o[0];
					return att.Title;
				}
			}
			public static string Description { 
				get {
					object[] o = _Assy.GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
					AssemblyDescriptionAttribute att = (AssemblyDescriptionAttribute)o[0];
					return att.Description;
				}
			}
			public static string Configuration { 
				get { 			
					object[] o = _Assy.GetCustomAttributes(typeof(AssemblyConfigurationAttribute), false);
					AssemblyConfigurationAttribute att = (AssemblyConfigurationAttribute)o[0];
					return att.Configuration;
				}
			}
			public static string Company { 
				get { 
					object[] o = _Assy.GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
					AssemblyCompanyAttribute att = (AssemblyCompanyAttribute)o[0];
					return att.Company;
				}
			}
			public static string Product { 
				get { 
					object[] o = _Assy.GetCustomAttributes(typeof(AssemblyProductAttribute), false);
					AssemblyProductAttribute att = (AssemblyProductAttribute)o[0];
					return att.Product;
				}
			}
			public static string Copyright { 
				get { 
					object[] o = _Assy.GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
					AssemblyCopyrightAttribute att = (AssemblyCopyrightAttribute)o[0];
					return att.Copyright;
				}
			}
			public static string Trademark { 
				get { 
					object[] o = _Assy.GetCustomAttributes(typeof(AssemblyTrademarkAttribute), false);
					AssemblyTrademarkAttribute att = (AssemblyTrademarkAttribute)o[0];
					return att.Trademark;
				}
			}
			public static string Culture { 
				get { 
					object[] o = _Assy.GetCustomAttributes(typeof(AssemblyCultureAttribute), false);
					AssemblyCultureAttribute att = (AssemblyCultureAttribute)o[0];
					return att.Culture;
				}
			}
			public static string Version { 
				get {
					Version ver = _Assy.GetName().Version;
					return "Version " + ver.Major + "." + ver.Minor + "." + ver.Build + "." + ver.Revision;
				}
			}
			#endregion
		}
		
		public enum OnlineIcon { On=0, Off=1 }
		
		public delegate void OnlineStatusHandler(object source, OnlineStatusArgs e);
		public class OnlineStatusArgs : EventArgs {
			private bool _online=false;
			private string _url="";
            public OnlineStatusArgs(bool online,string url) { this._online = online; this._url = url; }
            public bool Online { get { return this._online; } set { this._online = value; } }
			public string Url { get { return this._url; } set { this._url = value; } }
		}
	}
}
