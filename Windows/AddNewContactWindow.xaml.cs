using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using SebContactsApp.Classes;
using SQLite;

namespace SebContactsApp
{
    /// <summary>
    /// Interaction logic for AddNewContactWindow.xaml
    /// </summary>
    public partial class AddNewContactWindow : Window
    {
        public AddNewContactWindow()
        {
            InitializeComponent();
            
        }

        private void Save_Button_Click(object sender, RoutedEventArgs e)
        {
            Contact contact = new Contact();
            contact.Name = nameBox.Text;
            contact.Surname = surnameBox.Text;

            using (SQLiteConnection conn = new SQLiteConnection(App.databasePath))
            {
                conn.Insert(contact);
            }

            Close();

        }
    }
}
