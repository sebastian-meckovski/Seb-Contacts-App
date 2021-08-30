using SebContactsApp.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Forms;
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
            if (selectedContact == null)
            {
                selectedContact = new Contact();
            }

            DataContext = selectedContact;  // what does it do again?

            this.selectedContact = selectedContact;  // why do I need that

            //nameBox.Text = selectedContact.Name;
            surnameBox.Text = selectedContact.Surname;
            adressBox.Text = selectedContact.Address;
            companyBox.Text = selectedContact.Company;
            positionBox.Text = selectedContact.Position;
            mobileBox.Text = selectedContact.Mobile;
            //emailBox.Text = selectedContact.Email;
            //imageURLBox.Text = selectedContact.imgURL; // why is it blank when I edit it??
        }

        private void Edit_Button_Click(object sender, RoutedEventArgs e)
        {
            //selectedContact.Name = nameBox.Text;
            selectedContact.Surname = surnameBox.Text;
            selectedContact.Address = adressBox.Text;
            selectedContact.Company = companyBox.Text;
            selectedContact.Position = positionBox.Text;
            selectedContact.Mobile = mobileBox.Text;
            //selectedContact.Email = emailBox.Text;
            // selectedContact.imgURL = imageURLBox.Text;


            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.databasePath))
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

        private void Browse_Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();

            Contact contact = (Contact)DataContext;

            contact.imgURL = openFileDialog.FileName;
            DataContext = contact;
        }
    }
}