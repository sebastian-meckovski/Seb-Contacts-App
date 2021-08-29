using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using SQLite;

namespace SebContactsApp.Classes
{
    public class Contact : INotifyPropertyChanged
    {
        private string _imgURL;
        private string _email;

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string Company { get; set; }
        public string Position { get; set; }
        public string Mobile { get; set; }

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