using SebContactsApp.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            txtSurname.Text = contact.Surname;
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (contact == null)
            {
                //validations
                return;
            }
            contact.Name = txtName.Text;
            contact.Surname = txtSurname.Text;
            using (SQLiteConnection conn = new SQLiteConnection(ContactsApp.databasePath))
            {
                if (contact.ID == 0)
                {
                    conn.Insert(contact);
                }
                else
                {
                    conn.Update(contact);
                }
            }
            Close();
        }
    }
}
