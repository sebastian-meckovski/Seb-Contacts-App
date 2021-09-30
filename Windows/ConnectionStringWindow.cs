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
using SebContactsApp.Model;
using SebContactsApp.ViewModel;
using System.Data.SqlClient;

namespace SebContactsApp
{
    public partial class ConnectionStringWindow : Form
    {
        public dbCredentials dbCredentials { get; set; }
        public ConnectionStringWindow()
        {
            InitializeComponent();
        }

        private void ConnectionStringWindow_Load(object sender, EventArgs e)
        {
            txtServerName.Text = dbCredentials.serverName;
            txtDbName.Text = dbCredentials.dbName;
            txtServerLogin.Text = dbCredentials.serverLogin;
            txtServerPass.Text = dbCredentials.serverPass;
        }

        private void btnCredSave_Click(object sender, EventArgs e)
        {
            dbCredentials.serverName = txtServerName.Text;
            dbCredentials.dbName = txtDbName.Text;
            dbCredentials.serverLogin = txtServerLogin.Text;
            dbCredentials.serverPass = txtServerPass.Text;

            using (SQLiteConnection conn = new SQLiteConnection(ContactsApp.databasePath))
            {
                conn.Update(dbCredentials);
            }
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            try
            {
                string testConnectionString;
                testConnectionString = $@"Server={txtServerName.Text};
                                          Database={txtDbName.Text};
                                          User Id={txtServerLogin.Text};
                                          Password={txtServerPass.Text};";

                SqlConnection sqlConnection;
                sqlConnection = new SqlConnection(testConnectionString);

                sqlConnection.Open();

                CustomMessageBox cmb = new CustomMessageBox();
                cmb.Text = "Connection Status";
                cmb.label1.Text = $"Connection to {txtServerName.Text} was successful";
                cmb.ShowDialog();

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
