/* PhoneApplication     MainPage.xaml
 * Currency converter application.
 * This application offers conversion
 * between the European Euro and US Dollar.
 * Consider updating application with current
 * equivalencies.
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace PhoneApplication
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }
       
        private void btnUS_Click(object sender, RoutedEventArgs e)
        {
            txtBxUS.Text = (double.Parse(txtBxInput.Text) * 1.2979).ToString("C");
            txtBxExchange.Text = (1.2979).ToString("C");
            txtBxEuro.Text = double.Parse(txtBxInput.Text).ToString("C");
            txtBxInput.Text = "";
            txtBxInput.Focus();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            txtBxInput.Focus();
        }

        private void btnCanadian_Click(object sender, RoutedEventArgs e)
        {
            txtBxEuro.Text = (double.Parse(txtBxInput.Text) * 0.7705).ToString("C");
            txtBxExchange.Text = (0.7705).ToString("C");
            txtBxUS.Text = double.Parse(txtBxInput.Text).ToString("C");
            txtBxInput.Text = "";
            txtBxInput.Focus();
        }
    }
}