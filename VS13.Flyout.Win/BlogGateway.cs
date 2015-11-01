using System;
using System.Collections;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading;

namespace VS13 {
    //
    public class BlogGateway {
        //Members
        private static DataSet _BlogData = new DataSet();
        private static string _BlogFile = "BlogData.xml";

        //Interface
        static BlogGateway() { ViewBlog(); }
        private BlogGateway() { }

        public static DataSet ViewBlog() {
            //
            try {
                _BlogData.Clear();
                _BlogData.ReadXml(_BlogFile);
            }
            catch (Exception ex) { throw new ApplicationException(ex.Message); }
            return _BlogData;
        }
        public static bool AddBlogEntry(BlogEntry entry) {
            //
            bool added = false;
            try {
                _BlogData.Tables["BlogTable"].Rows.Add(new object[] { entry.Date,entry.UserID,entry.Comment });
                _BlogData.WriteXml(_BlogFile, XmlWriteMode.WriteSchema);
                added = true;
            }
            catch (Exception ex) { throw new ApplicationException(ex.Message); }
            return added;
        }
    }

    public class BlogEntry {
        //Members
        private DateTime mDate = DateTime.MinValue;
        private string mComment = "";
        private string mUserID = "";

        //Interface
        public BlogEntry() { }
        public DateTime Date { get { return this.mDate; } set { this.mDate = value; } }
        public string Comment { get { return this.mComment; } set { this.mComment = value; } }
        public string UserID { get { return this.mUserID; } set { this.mUserID = value; } }
    }

}