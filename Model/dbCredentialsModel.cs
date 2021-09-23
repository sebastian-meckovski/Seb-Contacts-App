using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace SebContactsApp.Model
{
    public class dbCredentials
    {
        [PrimaryKey]
        public int ID { get; set; }

        public string serverName { get; set; }

        public string dbName { get; set; }

        public string serverLogin { get; set; }
        
        public string serverPass { get; set; }

        public bool enableExport { get; set; }


    }
}
