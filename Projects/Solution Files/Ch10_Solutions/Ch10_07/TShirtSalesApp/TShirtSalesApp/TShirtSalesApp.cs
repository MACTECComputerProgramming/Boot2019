/* TShirtSalesApp.cs
 * This application enables users
 * to place an order for T-Shirts
 * from the Computer Club. Selections
 * are displayed.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TShirtSalesApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuDisplay_Click(object sender, EventArgs e)
        {
            if (lstBxSize.SelectedItems.Count > 0)
                if (cmboQuantity.SelectedIndex > -1)
                {
                    lblResult.Text = "Current Order\n-------------\nSize: " + lstBxSize.SelectedItem.ToString() +
                            "\nQuanity: " + cmboQuantity.SelectedText.ToString();
                }
                else
                    lblResult.Text = "Make Selections First!";
            else
                lblResult.Text = "Make Selections First!";
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
