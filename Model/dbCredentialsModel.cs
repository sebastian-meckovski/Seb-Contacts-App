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
        
        public string serverPass { get; set; }

        public string catName { get; set; }

    }
}
