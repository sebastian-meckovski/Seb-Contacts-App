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
using System.IO;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SebContactsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        List<Contact> contacts;
        private Contact selectedContact;

        #region INotifyPropertyChanged Implementation
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (propertyName != null && PropertyChanged != null)
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        public Contact SelectedContact { get => selectedContact; set { selectedContact = value; OnPropertyChanged(); } }
        public MainWindow()
        {
            Directory.CreateDirectory($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\Contact data");  // why this function doesn't work in App.xaml.cs file?
            InitializeComponent();
            contacts = new List<Contact>();
            UpdateData();
            DataContext = this;
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
            MakeSelection(myListView.Items.Count - 1);
        }

        private void Edit_Button_Click(object sender, RoutedEventArgs e)
        {
            editContact();
        }

        private void myListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            editContact();
        }

        private void editContact()
        {
            Contact selectedItem = (Contact)myListView.SelectedItem;
            int selectedIndex = myListView.SelectedIndex;

            if (selectedItem != null)
            {
                editContactWindow editContactWindow = new editContactWindow(selectedItem);
                editContactWindow.ShowDialog();
            }
            UpdateData();
            MakeSelection(selectedIndex);
        }

        private void myListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Contact selectedItem = (Contact)myListView.SelectedItem;
            if (selectedItem != null)
            {
                nameLabel.Content = selectedItem.Name;
                surnameLabel.Content = selectedItem.Surname;
                addressLabel.Content = selectedItem.Address;
                companyLabel.Content = selectedItem.Company;
                postionLabel.Content = selectedItem.Position;
                mobileLabel.Content = selectedItem.Mobile;
                emailLabel.Content = selectedItem.Email;
                //imgURLpath.Source = selectedItem.imgURL;
                if (selectedItem.imgURL != null)
                {
                    try
                    {
                        imgURLpath.Source = new BitmapImage(new Uri(selectedItem.imgURL));
                    }
                    catch
                    {
                        imgURLpath.Source = null;
                    }
                }
            }
        }

        private void MakeSelection(int Index)
        {
            try
            {
                SelectedContact = (Contact)myListView.Items[Index];
            }
            catch (ArgumentOutOfRangeException)
            {
                if (myListView.Items.Count > 0)
                {
                    SelectedContact = (Contact)myListView.Items[myListView.Items.Count - 1];
                }
                else
                {
                    nameLabel.Content = "N/A";
                    surnameLabel.Content = "N/A";
                    addressLabel.Content = "N/A";
                    companyLabel.Content = "N/A";
                    postionLabel.Content = "N/A";
                    mobileLabel.Content = "N/A";
                    emailLabel.Content = "N/A";
                }
            }
        }

        private void Delete_Button_Click(object sender, RoutedEventArgs e)
        {
            int selectedIndex = myListView.SelectedIndex;
            deleteContact();
            UpdateData();
            MakeSelection(selectedIndex);
        }

        private void deleteContact()
        {
            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.databasePath))
            {
                conn.Delete(SelectedContact);
            }
        }
    }
}