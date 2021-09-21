using SebContactsApp.Entities;
using SebContactsApp.Model;
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
            SebTestData2021Entities db = new SebTestData2021Entities();
            var customers = db.customer_detail.Select(y => new CompanyClass()
            {
                cd_id = y.cd_id,
                cd_statement_name = y.cd_statement_name
            }).ToList();

            companyListDropdown.DataSource = customers;
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            selectedId = ((CompanyClass)companyListDropdown.SelectedItem).cd_id;
            Close();
        }
    }
}
