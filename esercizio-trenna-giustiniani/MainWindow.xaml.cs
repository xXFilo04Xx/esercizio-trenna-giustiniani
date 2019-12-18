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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace esercizio_trenna_giustiniani
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

        private void btngreet_Click(object sender, RoutedEventArgs e)
        {
            string a = txtnome.Text;
            string b = txtcognome.Text;
            string c = txtnascita1.Text;
              MessageBox.Show($"hi you were born on {c} and and your name is {a}{b} ","Hello",MessageBoxButton.OK,MessageBoxImage.Information);
           
        }

        private void chbacconsento_Checked(object sender, RoutedEventArgs e)
        {
            btnprint.IsEnabled = true;
        }

        private void btnprint_Click(object sender, RoutedEventArgs e)
        {
            string a = txtnome.Text;
            string b = txtcognome.Text;
            string c = txtnascita1.Text;
            txtrisultato.Text = $"hi you were born on {c} and and your name is {a}{b} ";
        }
    }
}
