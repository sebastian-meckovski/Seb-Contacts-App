using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace SebContactsApp.Model
{
    public class Contact
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Address { get; set; }

        public string Company { get; set; }

        public string Position { get; set; }

        public string Mobile { get; set; }

        public string Email { get; set; }

        public string imgURL { get; set; }

        public string FullName
        {
            get
            {
                return $"{Name} {Surname}";
            }
        }

    }
}
