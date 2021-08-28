using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            contact.Address = addressBox.Text;
            contact.Company = companyBox.Text;
            contact.position = companyBox.Text;
            contact.mobile = companyBox.Text;
            contact.email = companyBox.Text;

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
            //using (var dialog1 = new System.Windows.Forms.FolderBrowserDialog())
            //{
            //    System.Windows.Forms.DialogResult result1 = dialog1.ShowDialog();
            //    if (result1 == System.Windows.Forms.DialogResult.OK)
            //    {
            //        outputFilePathLabel.Content = dialog1.SelectedPath;
            //    }
            //}
        }
    }
}