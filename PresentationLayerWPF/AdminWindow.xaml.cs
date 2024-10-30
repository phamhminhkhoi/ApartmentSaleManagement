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

namespace PresentationLayerWPF
{
    /// <summary>
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
        }

        private void MemberButton_Click(object sender, RoutedEventArgs e)
        {
            MemberPage memberPage = new MemberPage();   
            MainFrame.Navigate(memberPage);
        }

        private void PropertyButton_Click(object sender, RoutedEventArgs e)
        {
            PropertyPage propertyPage = new PropertyPage();

            // Navigate to the PropertyPage in the Frame
            MainFrame.Navigate(propertyPage);
        }

        //private void TransactionButton_Click(object sender, RoutedEventArgs e)
        //{
        //    MessageBox.Show("Sorry ! You cannot using this feature for now. We will update in time.");

        //}

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();

        }
    }
}
