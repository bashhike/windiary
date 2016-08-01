﻿using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using System.IO;

namespace DiaryApp
{
    /// <summary>
    /// Interaction logic for EditFile.xaml
    /// </summary>
    public partial class EditFile : Window
    {
        string filename = File.ReadAllText("edit.dat");
        public EditFile()
        {
            InitializeComponent();
            LoadFile();
        }

        private void SubmitNewEntry_Click(object sender, RoutedEventArgs e)
        {
            string DiaryEntryText = EditText.Text;
            File.WriteAllText(MainWindow.CurrentPath + "\\" + filename, DiaryEntryText);
            MainWindow NewWindow = new MainWindow();
            NewWindow.Show();
            Close();
        }

        private void CancelNewEntry_Click(object sender, RoutedEventArgs e)
        {
            MainWindow NewWindow = new MainWindow();
            NewWindow.Show();
            Close();
        }

        void LoadFile()
        {
            string InitialText = File.ReadAllText(MainWindow.CurrentPath + "\\" + filename);
            EditText.Text = InitialText;
        }
    }
}