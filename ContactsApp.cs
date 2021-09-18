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
using System.Data.SqlClient;
using MetroSet_UI.Forms;

namespace SebContactsApp
{

    public partial class ContactsApp : MetroSetForm
    {
        static string specialFolder = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\Contact Data";
        static string databaseName = "Contacts.db";
        public static string databasePath = Path.Combine(specialFolder, databaseName);

        SqlConnection connection;
        SqlCommand contactCommand;
        SqlCommand addressCommand;

        public List<Contact> contacts;
        public List<dbCredentials> dbCredentialsList;

        public ContactsApp()
        {
            InitializeComponent();
            Directory.CreateDirectory($"{specialFolder}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateData();
            makeSelection(listboxContacts.Items.Count - 1);
        }

        private void UpdateData()
        {
            using (SQLiteConnection conn = new SQLiteConnection(databasePath))
            {
                conn.CreateTable<Contact>();
                conn.CreateTable<dbCredentials>();

                contacts = conn.Table<Contact>().ToList();
                dbCredentialsList = conn.Table<dbCredentials>().ToList();

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
            if (dbCredentialsList.Count == 0)
            {
                using (SQLiteConnection conn = new SQLiteConnection(ContactsApp.databasePath))
                {
                    dbCredentials dbCredentials = new dbCredentials();
                    conn.Insert(dbCredentials);
                    dbCredentialsList = conn.Table<dbCredentials>().ToList();
                }
            }
            connectionStringWindow.dbCredentials = dbCredentialsList[0];
            connectionStringWindow.ShowDialog();
            UpdateData();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            var connString = $@"Server={dbCredentialsList[0].serverName};Database={dbCredentialsList[0].dbName};User Id={dbCredentialsList[0].serverLogin};Password={dbCredentialsList[0].serverPass};";
            //var connString = $"Server = myServerAddress; Database = myDataBase; User Id = myUsername; Password = myPassword;";
            connection = new SqlConnection(connString);
            try
            {
                connection.Open();
                contactCommand = new SqlCommand("INSERT INTO customer_contact(cc_name, cc_position, cc_customer_id)" +
                                               $"VALUES('{((Contact)listboxContacts.SelectedItem).FullName}'," +
                                                      $"'{((Contact)listboxContacts.SelectedItem).Position}', 2)" +
                                                      $"SELECT CAST(scope_identity() AS int)", connection);

                int newId = (int)contactCommand.ExecuteScalar();
                MessageBox.Show($"The ID insterted is {newId}");

                addressCommand = new SqlCommand("INSERT INTO customer_contact_address(ccad_cc_id, ccad_address1)" +
                                                $"VALUES({newId}," +
                                                        $"'{((Contact)listboxContacts.SelectedItem).Address}')", connection);

                addressCommand.ExecuteNonQuery();

                MessageBox.Show("Success!");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
