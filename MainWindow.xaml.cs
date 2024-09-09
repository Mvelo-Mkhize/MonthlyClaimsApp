﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MonthlyClaimsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ProgramCoordinatorLogin(object sender, RoutedEventArgs e)
        {
            this.Hide();
            ProgramCoordinatorLogin window = new ProgramCoordinatorLogin();
            window.Show();
        }

        private void LecturerLogin(object sender, RoutedEventArgs e)
        {
            this.Hide();
            LecturerLogin window = new LecturerLogin();
            window.Show();
        }
    }
}