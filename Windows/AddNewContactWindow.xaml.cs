using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
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
            DataContext = new Contact();
        }

        private void Save_Button_Click(object sender, RoutedEventArgs e)
        {
            Contact contact = (Contact)DataContext;
            contact.Name = nameBox.Text;
            contact.Surname = surnameBox.Text;
            contact.Address = addressBox.Text;
            contact.Company = companyBox.Text;
            contact.position = positionBox.Text;
            contact.mobile = mobileBox.Text;
            //contact.email = emailBox.Text;

            //contact.imgURL = imageURLBox.Text


            using (SQLiteConnection conn = new SQLiteConnection(App.databasePath))
            {
                conn.Insert(contact);
            }
            Debug.WriteLine("SaveButton Clicked");
            Close();
        }

        private void Browse_Button_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Browse button clicked");
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            Contact contact = (Contact)DataContext;
            contact.imgURL = openFileDialog.FileName;
            DataContext = contact;
            //imageURLBox.Text = openFileDialog.FileName; // Why is this not accesible
        }
    }
}