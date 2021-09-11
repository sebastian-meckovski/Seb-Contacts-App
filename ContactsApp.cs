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

        public List<Contact> contacts;

        public ContactsApp()
        {
            InitializeComponent();
            Directory.CreateDirectory($"{specialFolder}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateData();
            makeSelection(listboxContacts.Items.Count - 1);
            image.SizeMode = PictureBoxSizeMode.StretchImage;
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

            addNew.ShowDialog();

            UpdateData();
            makeSelection(listboxContacts.Items.Count - 1);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int myIndex = listboxContacts.SelectedIndex;
            if (listboxContacts.Items.Count > 0)
            {
                addNew addNew = new addNew();
                addNew.contact = contacts[myIndex];
                addNew.ShowDialog();
            }

            UpdateData();
            makeSelection(myIndex);
        }

        private void selectionChanged(object sender, EventArgs e)
        {
            lblName.Text = ((Contact)listboxContacts.SelectedItem).FullName;
            lblAddress.Text = ((Contact)listboxContacts.SelectedItem).Address;
            lblCompany.Text = ((Contact)listboxContacts.SelectedItem).Company;
            lblPosition.Text = ((Contact)listboxContacts.SelectedItem).Position;
            lblPhone.Text = ((Contact)listboxContacts.SelectedItem).Phone;
            lblEmail.Text = ((Contact)listboxContacts.SelectedItem).Email;

            try
            {
                image.Load(((Contact)listboxContacts.SelectedItem).imgURL);
            } catch (Exception)
            {
                image.Image = Properties.Resources.DefaultImage;
            }
        }


        private void makeSelection(int index)
        {
            if (listboxContacts.Items.Count > 1 && index > 0)
            {
                try 
                {
                    listboxContacts.SelectedIndex = index;
                }
                catch
                {
                
                }
            }
        }

        private void deleteClick(object sender, EventArgs e)
        {
            int myIndex = listboxContacts.SelectedIndex;
            if (listboxContacts.Items.Count > 0)
            {
                using (SQLiteConnection conn = new SQLiteConnection(ContactsApp.databasePath))
                {
                    conn.Delete(listboxContacts.SelectedItem);
                }
            }
            UpdateData();
            makeSelection(myIndex);
        }

        private void enableDBExport(object sender, EventArgs e)
        {
            if(checkBoxExport.CheckState == CheckState.Checked)
            {
                checkBoxExport.CheckState = CheckState.Unchecked;
                setDBconnSettings.Enabled = false;
            }
            else
            {
                checkBoxExport.CheckState = CheckState.Checked;
                setDBconnSettings.Enabled = true;
            }
        }

        private void setDBconnSettings_Click(object sender, EventArgs e)
        {
            ConnectionStringWindow connectionStringWindow = new ConnectionStringWindow();
            connectionStringWindow.ShowDialog();
        }
    }
}
