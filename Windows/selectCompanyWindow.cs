using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SebContactsApp
{
    public partial class selectCompanyWindow : Form
    {
        List<string> myList;
        public string companyListCommnand;

        public selectCompanyWindow()
        {
            InitializeComponent();
        }

        private void selectContactWindow_Load(object sender, EventArgs e)
        {
            SebTestData2021Entities db = new SebTestData2021Entities();
            var customers = db.customer_detail.Select(y => new
            {
                cd_id = y.cd_id,
                cd_statement_name = y.cd_statement_name
            }).ToList();

            companyListDropdown.DataSource = customers;
        }
    }
}
