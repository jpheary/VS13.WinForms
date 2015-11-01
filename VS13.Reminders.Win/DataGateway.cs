using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS13 {
    //Gateway to some data source
    class DataGateway {
        //Members

        //Interface
        public DataGateway() { }
        public static IssueDataset GetIssues() {
            //Get issues
            IssueDataset issues = new IssueDataset();
            try {
                issues.ReadXml("Data\\Issues.xml");
            }
            catch (Exception ex) { throw new ApplicationException(ex.Message); }
            return issues;
        }
    }
}
