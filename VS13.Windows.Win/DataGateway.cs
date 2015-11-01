using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS13 {
    //
    class DataGateway {
		//Members

		//Interface
        public DataGateway() { }

        public static ServiceInfo GetServiceInfo() {
            //Get information about the state of the data service
            ServiceInfo info = null;
            try {
                info = new ServiceInfo();
                info.Connection = "http://jpheary.cloudapp.net/cloudservices.svc";
                info.Description = "Data Gateway";
            }
            catch (Exception ex) { throw new ApplicationException(ex.Message,ex); }
            return info;
        }
    }

    public class ServiceInfo {
        private string mDescription = "",mConnection = "";

        public string Description { get { return this.mDescription; } set { this.mDescription = value; } }
        public string Connection { get { return this.mConnection; } set { this.mConnection = value; } }
    }

}
