using SebContactsApp.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SebContactsApp
{

    public partial class ContactsApp : Form
    {
        static string specialFolder = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\Contact Data";
        static string databaseName = "Contacts.db";
        public static string databasePath = Path.Combine(specialFolder, databaseName);

        List<Contact> contacts;

        public ContactsApp()
        {
            InitializeComponent();
            Directory.CreateDirectory($"{specialFolder}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listboxContacts.DisplayMember = "FullName";
            UpdateData();
        }

        private void UpdateData()
        {
            using (SQLiteConnection conn = new SQLiteConnection(databasePath))
            {
                conn.CreateTable<Contact>();
                contacts = conn.Table<Contact>().ToList();
                listboxContacts.DataSource = contacts;
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            addNew addNew = new addNew();
            addNew.contact = new Contact();
            //addNew.contact.Name = "Sebastian";
            addNew.ShowDialog();

            UpdateData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            addNew addNew = new addNew();
            addNew.contact = contacts[listboxContacts.SelectedIndex];
            addNew.ShowDialog();
            //MessageBox.Show("Edit Click!");

            // is it possible to edit existing contact by passing contact object to btn_AddNew_Click?
            // if it was WPF you could pass the contact as an argument to addNew function like this:
            // addNew(selectedContact)
            //
            // But it doesn't work in winforms
            // can you advise?

        }
    }
}
