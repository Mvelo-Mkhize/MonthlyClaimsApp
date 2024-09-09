using System;
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

namespace MonthlyClaimsApp
{
    /// <summary>
    /// Interaction logic for ProgramCoordinator.xaml
    /// </summary>
    public partial class ProgramCoordinator : Window
    {
        public ProgramCoordinator()
        {
            InitializeComponent();
        }

        private void MainWindow1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow window = new MainWindow();
            window.Show();
        }

        private void Exit1(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
