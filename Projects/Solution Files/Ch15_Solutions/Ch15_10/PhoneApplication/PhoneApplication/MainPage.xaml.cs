/* PhoneApplication   MainPage.xaml
 * This Phone app creates a security
 * hash code using values (first name,
 * last name, student id and birth year)
 * entered by the user. The security
 * value consists of the first character
 * of the user's name, the student's Id,
 * the last two digits of their birth year
 * and the number of characters in their
 * name.
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
       
        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            txtBxName.Focus();
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            txtBlkResult.Text = "New Code: " +
                                (txtBxName.Text).Substring(0, 1) +
                                txtBxID.Text +
                                txtBxYear.Text.Substring(2, 2) +
                                txtBxName.Text.Length;
        }

      
    }
}