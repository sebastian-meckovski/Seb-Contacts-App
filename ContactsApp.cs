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
using SebContactsApp.ViewModel;

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

        public ContactsApp()
        {
            InitializeComponent();
            Directory.CreateDirectory($"{specialFolder}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateData();
            makeSelection(listboxContacts.Items.Count - 1);

            CreateSettings();
        }

        private void UpdateData()
        {
            using (SQLiteConnection conn = new SQLiteConnection(databasePath))
            {
                conn.CreateTable<Contact>();
                conn.CreateTable<dbCredentials>();

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
                    // Do nothing in case error happens
                }
            }
        }

        private void deleteClick(object sender, EventArgs e)
        {
            int myIndex = listboxContacts.SelectedIndex;
            if (listboxContacts.Items.Count > 0)
            {
                using (SQLiteConnection conn = new SQLiteConnection(databasePath))
                {
                    conn.Delete(listboxContacts.SelectedItem);
                }
            }
            UpdateData();
            makeSelection(myIndex);
        }

        private void enableDBExport_click(object sender, EventArgs e)
        {
            if (checkBoxExport.CheckState == (CheckState)1)
            {
                DatabaseCredentials.dbCredential.enableExport = 0;
                checkBoxExport.CheckState = (CheckState)DatabaseCredentials.dbCredential.enableExport;
                setDBconnSettings.Enabled = false;
                exportSelectedContactToolStripMenuItem.Enabled = false;
            }
            else
            {
                DatabaseCredentials.dbCredential.enableExport = 1;
                checkBoxExport.CheckState = (CheckState)DatabaseCredentials.dbCredential.enableExport;
                setDBconnSettings.Enabled = true;
                exportSelectedContactToolStripMenuItem.Enabled = true;
            }
            using (SQLiteConnection conn = new SQLiteConnection(databasePath))
            {
                conn.Update(DatabaseCredentials.dbCredential);
            }
        }

        private void setEnableExportButtonStatus(int value)
        {
            checkBoxExport.CheckState = (CheckState)value; // sets value of the of Export 
            setDBconnSettings.Enabled = Convert.ToBoolean(value);
            exportSelectedContactToolStripMenuItem.Enabled = Convert.ToBoolean(value);
        }

        private void CreateSettings()
        {
            if (DatabaseCredentials.dbCredential==null)
            {
                
                using (SQLiteConnection conn = new SQLiteConnection(databasePath))
                {
                    DatabaseCredentials.dbCredential = conn.Table<dbCredentials>().FirstOrDefault(); //not sure what it does
                    if (DatabaseCredentials.dbCredential == null)
                    {
                        dbCredentials dbCredentials = new dbCredentials();
                        conn.Insert(dbCredentials);
                        DatabaseCredentials.dbCredential = conn.Table<dbCredentials>().FirstOrDefault(); //not sure what it does
                    }                    
                }
            }
            setEnableExportButtonStatus(DatabaseCredentials.dbCredential.enableExport);
        }

        private void setDBconnSettings_Click(object sender, EventArgs e)
        {
            ConnectionStringWindow connectionStringWindow = new ConnectionStringWindow();

            connectionStringWindow.dbCredentials = DatabaseCredentials.dbCredential;
            connectionStringWindow.ShowDialog();
            UpdateData();
        }

        private void ExportSelected_Click(object sender, EventArgs e)
        {
            
            connection = new SqlConnection(DatabaseCredentials.connectionString);
            try
            {
                selectCompanyWindow selectCompanyWindow = new selectCompanyWindow();
                selectCompanyWindow.ShowDialog();

                if (selectCompanyWindow.selectedId == null)
                {
                    return;
                }


                connection.Open();
                contactCommand = new SqlCommand("INSERT INTO customer_contact(cc_name ,cc_first_name, cc_last_name, cc_position, cc_telephone, cc_email, cc_customer_id)" +
                                               $"VALUES('{((Contact)listboxContacts.SelectedItem).FullName}'," +
                                                      $"'{((Contact)listboxContacts.SelectedItem).Name}'," +
                                                      $"'{((Contact)listboxContacts.SelectedItem).Surname}'," +
                                                      $"'{((Contact)listboxContacts.SelectedItem).Position}'," +
                                                      $"'{((Contact)listboxContacts.SelectedItem).Phone}'," +
                                                      $"'{((Contact)listboxContacts.SelectedItem).Email}'," +
                                                      $" {selectCompanyWindow.selectedId})" +
                                                      $"SELECT CAST(scope_identity() AS int)", connection);

                int newId = (int)contactCommand.ExecuteScalar();

                addressCommand = new SqlCommand("INSERT INTO customer_contact_address(ccad_cc_id, ccad_address1)" +
                                                $"VALUES({newId}, '{((Contact)listboxContacts.SelectedItem).Address}')", connection);

                CustomMessageBox cmb = new CustomMessageBox();
                cmb.label1.Text = $"{((Contact)listboxContacts.SelectedItem).FullName} contact has been successfully exported to OrderWise Database";
                cmb.Text = "Customer Exported Successfully";
                cmb.ShowDialog();

                addressCommand.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
