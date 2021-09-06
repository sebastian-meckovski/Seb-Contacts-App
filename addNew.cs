using SebContactsApp.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SebContactsApp
{
    public partial class addNew : Form
    {
        public Contact contact { get; set; }
        public addNew()
        {
            InitializeComponent();
        }

        private void addNew_Load(object sender, EventArgs e)
        {
            txtName.Text = contact.Name;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Contact seb = contact;
            seb.Name = txtName.Text;
            seb.Surname = txtSurname.Text;

            using (SQLiteConnection conn = new SQLiteConnection(SebContactsApp.ContactsApp.databasePath))
            {
                conn.Insert(seb);
            }

            Close();
        }

    }
}
