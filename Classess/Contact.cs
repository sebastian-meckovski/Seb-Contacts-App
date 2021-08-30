using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using SQLite;

namespace SebContactsApp.Classes
{
    public class Contact : INotifyPropertyChanged  //what's that class?
    {
        private string _name;
        private string _surname;
        private string _address;
        private string _company;
        private string _position;
        private string _mobile;
        private string _email;
        private string _imgURL;

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string Name 
        {
            get { return _name; }
            set 
            {
                _name = value;
                OnPropertyChanged();
            } 
        }

        public string Surname
        {
            get {return _surname; }
            set 
            {
                _surname = value;
                OnPropertyChanged();
            } 
        }

        public string Address
        {
            get { return _address; }
            set 
            { 
                _address = value;
                OnPropertyChanged();
            } 
        }

        public string Company 
        {
            get { return _company; }
            set 
            { 
                _company = value;
                OnPropertyChanged();
            }
        }

        public string Position 
        { 
            get { return _position;}
            set 
            { 
                _position = value;
                OnPropertyChanged();
            }
        }

        public string Mobile
        {
            get { return _mobile; }
            set
            {
                _mobile = value;
                OnPropertyChanged();
            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged();
            }
        }

        public string imgURL
        {
            get { return _imgURL; }
            set
            {
                _imgURL = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}