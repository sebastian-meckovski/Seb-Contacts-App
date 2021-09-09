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
            txtSurname.Text = contact.Surname;
            txtCompany.Text = contact.Company;
            txtPosition.Text = contact.Position;
            txtPhone.Text = contact.Phone;
            txtEmail.Text = contact.Email;
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (contact == null)
            {
                //validations
                // still not sure why I need that
                return;
            }
            contact.Name = txtName.Text;
            contact.Surname = txtSurname.Text;
            contact.Address = txtAddress.Text;
            contact.Company = txtCompany.Text;
            contact.Position = txtPosition.Text;
            contact.Phone = txtPhone.Text;
            contact.Email = txtEmail.Text;

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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
