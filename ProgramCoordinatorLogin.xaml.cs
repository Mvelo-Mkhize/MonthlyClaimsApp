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
    /// Interaction logic for ProgramCoordinatorLogin.xaml
    /// </summary>
    public partial class ProgramCoordinatorLogin : Window
    {
        public ProgramCoordinatorLogin()
        {
            InitializeComponent();
        }

        private void ProgramCoordinatorLogIn(object sender, RoutedEventArgs e)
        {
            this.Hide();
            ProgramCoordinator window = new ProgramCoordinator();
            window.Show();
        }
    }
}
