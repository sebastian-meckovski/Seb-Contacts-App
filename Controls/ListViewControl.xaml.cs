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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SebContactsApp.Controls
{
    /// <summary>
    /// Interaction logic for ListViewControl.xaml
    /// </summary>
    public partial class ListViewControl : UserControl
    {
        public Contact Contact
        {
            get { return (Contact)GetValue(ContactProperty); }
            set { SetValue(ContactProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Contact.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ContactProperty =
            DependencyProperty.Register("Contact", typeof(Contact), typeof(ListViewControl), new PropertyMetadata(new Contact() { Name = "Name", Surname = "Surname" }, SetText));

        private static void SetText(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ListViewControl control = d as ListViewControl;
            control.nameTextBlock.Text = (e.NewValue as Contact).Name;
            control.surnameTextBlock.Text = (e.NewValue as Contact).Surname;
        }

        public ListViewControl()
        {
            InitializeComponent();
        }
    }
}