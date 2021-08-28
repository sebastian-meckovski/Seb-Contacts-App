using SebContactsApp.Classes;
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

namespace SebContactsApp
{
    /// <summary>
    /// Interaction logic for editContactWindow.xaml
    /// </summary>
    public partial class editContactWindow : Window
    {
        Contact selectedContact;
        public editContactWindow(Contact selectedContact)
        {
            InitializeComponent();

            this.selectedContact = selectedContact;

            nameBox.Text = selectedContact.Name;
            surnameBox.Text = selectedContact.Surname;
            adressBox.Text = selectedContact.Address;
            companyBox.Text = selectedContact.Company;
            positionBox.Text = selectedContact.position;
            mobileBox.Text = selectedContact.mobile;
            emailBox.Text = selectedContact.email;
        }

        private void Edit_Button_Click(object sender, RoutedEventArgs e)
        {
            selectedContact.Name = nameBox.Text;
            selectedContact.Surname = surnameBox.Text;
            selectedContact.Address = adressBox.Text;
            selectedContact.Company = companyBox.Text;
            selectedContact.position = positionBox.Text;
            selectedContact.mobile = mobileBox.Text;
            selectedContact.email = emailBox.Text;

            using(SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.databasePath))
            {
                conn.Update(selectedContact);
            }
            Close();
        }

        private void Delete_Button_Click(object sender, RoutedEventArgs e)
        {
            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.databasePath))
            {
                conn.Delete(selectedContact);
            }
            Close();
        }
    }
}
