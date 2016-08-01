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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow NewWindow = new MainWindow();
            NewWindow.Show();
            Close();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            if (CurDir.Text != "")
            {
                string[] text = { "# Please do not edit this file. Line numbers matter here.", CurDir.Text };
                File.WriteAllLines("diaryconfig.ini", text);
            }
            MainWindow NewWindow = new MainWindow();
            NewWindow.Show();
            Close();
        }
    }
}
