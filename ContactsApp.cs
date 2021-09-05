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
            UpdateData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listboxContacts.DisplayMember = "Name";
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

        private void button1_Click(object sender, EventArgs e)
        {
            addNew addNew = new addNew();
            addNew.ShowDialog();

            UpdateData();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
