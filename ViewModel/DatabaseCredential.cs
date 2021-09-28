using SebContactsApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SebContactsApp.ViewModel
{
    public static class DatabaseCredentials
    {
        
        public static dbCredentials dbCredential { get; set; }
        public static string connectionString
        {
            get
            {
                return $@"Server={dbCredential.serverName};
                          Database={dbCredential.dbName};
                          User Id={dbCredential.serverLogin};
                          Password={dbCredential.serverPass};";
            }
        }
    }
}
