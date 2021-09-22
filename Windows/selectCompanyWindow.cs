using SebContactsApp.Entities;
using SebContactsApp.Model;
using SebContactsApp.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SebContactsApp
{
    public partial class selectCompanyWindow : Form
    {
        public int selectedId;

        public selectCompanyWindow()
        {
            InitializeComponent();
        }

        private void selectContactWindow_Load(object sender, EventArgs e)
        {
            //var dbCredentials = DatabaseCredentials.dbCredentials[0];
            //var db = SebTestData2021Entities.ConnectToSqlServer(dbCredentials.serverName, dbCredentials.dbName, dbCredentials.serverLogin, dbCredentials.serverPass, false);

            
            //var customers = db.customer_detail.Select(y => new CompanyClass()
            //{
            //    cd_id = y.cd_id,
            //    cd_statement_name = y.cd_statement_name
            //}).ToList();

            //companyListDropdown.DataSource = customers;
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            //selectedId = ((CompanyClass)companyListDropdown.SelectedItem).cd_id;
            // selectedID needs to be the ID of the selected company from the dropdown
            selectedId = 4;
            Close();
        }
    }
}
