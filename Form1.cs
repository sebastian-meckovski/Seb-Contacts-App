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
using ADOX;

namespace SebContactsApp
{
    public partial class Form1 : Form
    {
        static string specialFolder = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\Contact Data";
        static string databaseName = "Contacts.accdb";
        public static string databasePath = Path.Combine(specialFolder, databaseName);

        string connString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={databasePath};Persist Security Info=False;";


        public Form1()
        {
            InitializeComponent();
            Directory.CreateDirectory($"{specialFolder}");

            var catalog = new Catalog();
            catalog.Create("Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + databasePath + "; Jet OLEDB:Engine Type=5");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
