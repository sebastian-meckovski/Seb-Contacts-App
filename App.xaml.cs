﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace SebContactsApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        static string databaseName = "contacts.db";
        static string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public static string databasePath = System.IO.Path.Combine(folderPath, databaseName);
    }
}