using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace SebContactsApp.Classes
{
    public class Contact
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string Company { get; set; }
        public string position { get; set; }
        public string mobile { get; set; }
        public string email { get; set; }
        public string imgURL { get; set; }
    }
}