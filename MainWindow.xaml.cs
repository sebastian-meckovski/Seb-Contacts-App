using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using SebContactsApp.Classes;
using SQLite;

namespace SebContactsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Contact> contacts;

        public MainWindow()
        {
            InitializeComponent();
            contacts = new List<Contact>();
            UpdateData();
        }

        private void UpdateData()
        {
            using (SQLiteConnection conn = new SQLiteConnection(App.databasePath))
            {
                conn.CreateTable<Contact>();
                contacts = conn.Table<Contact>().ToList();
                myListView.ItemsSource = contacts;
            }
        }

        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {
            AddNewContactWindow addNewContactWindow = new AddNewContactWindow();

            addNewContactWindow.ShowDialog();

            UpdateData();
        }

        private void Edit_Button_Click(object sender, RoutedEventArgs e)
        {
            editContactWindow editContactWindow = new editContactWindow();
            editContactWindow.ShowDialog();
            UpdateData();
        }
    }
}
