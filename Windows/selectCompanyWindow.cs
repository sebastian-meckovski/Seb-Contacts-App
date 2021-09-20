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
            companyListCommnand = "SELECT cd_id, cd_statement_name FROM customer_detail";

            myList = new List<String>()
            {
                "One",
                "Two",
                "Three",
            };

            companyListDropdown.DataSource = myList;
        }
    }
}
