using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS13 {
    //
    class RoleServiceGateway {
        //Members
        private static bool _state = false;
        private static string _address = "";
        private static string[] _roles = null;

        private const string ROLE_SALESREP = "SalesRep";

        //Interface
        static RoleServiceGateway() { }
        private RoleServiceGateway() { }

        public static string[] GetRolesForCurrentUser() {
            //Get all roles for the current user
            try {
                if (_roles == null) {
                    _roles = new string[] { ROLE_SALESREP };
                }
            }
            catch (Exception ex) { throw new ApplicationException(ex.Message,ex); }
            return _roles;
        }
        public static string GetRoleForCurrentUser() {
            if (IsSalesRep) return ROLE_SALESREP;
            else {
                if (_roles.Length > 0) return _roles[0]; else return "No roles";
            }
        }
        public static bool IsSalesRep {
            get {
                bool authorized = false;
                string[] roles = GetRolesForCurrentUser();
                for (int i = 0;i < roles.Length;i++) {
                    authorized = (roles[i] == ROLE_SALESREP);
                    if (authorized) break;
                }
                return authorized;
            }
        }
    }
}
