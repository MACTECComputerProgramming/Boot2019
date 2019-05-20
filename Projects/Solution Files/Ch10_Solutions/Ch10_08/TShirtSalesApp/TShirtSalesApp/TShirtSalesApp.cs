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
using System.Collections;

namespace TShirtSalesApp
{
    public partial class TShirtSalesAppForm : Form
    {
        private ArrayList  qtyArray;
        private ArrayList sizeArray;
        private double totalCost;

        public TShirtSalesAppForm()
        {
            InitializeComponent();
        }

        private void menuDisplay_Click(object sender, EventArgs e)
        {
            string result;

            result = "Current Order\n---------------\n";
            for (int i = 0; i < sizeArray.Count; i++ )
            {
                result += "Size: " + sizeArray[i].ToString() +
                          "\nQuanity: " + qtyArray[i].ToString() +"\n\n";
            }
            result += "\nTotal Due: " + totalCost.ToString("C");
            MessageBox.Show(result, "Computer Club T-Shirts");
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This application enables you to order" +
                            "\nT-Shirts. All shirts except specialty " +
                            "\nones, X-Small and X-Large are $16. The" +
                            "\nX-Small and XX-Large sell for $20 each.\n\n" +
                            "More than one size may be added to the order.\n" +
                            "The Process menu has options to Add to Cart\n" +
                            "and Check Out - once the order is complete.",
                            "Computer Club T-Shirt Sales App");
        }

        private void menuAddToCart_Click(object sender, EventArgs e)
        {
            if (lstBxSize.SelectedItems.Count > 0)
                if (cmboQuantity.SelectedIndex > -1)
                {
                    sizeArray.Add(lstBxSize.SelectedItem.ToString());
                    qtyArray.Add(cmboQuantity.SelectedItem.ToString());
                    if (lstBxSize.SelectedIndex == 0 || lstBxSize.SelectedIndex == 5)
                    {
                        totalCost += int.Parse(cmboQuantity.Text) * 20;
                        ClearSelections();
                    }
                    else
                    {
                        totalCost += int.Parse(cmboQuantity.Text) * 16;
                        ClearSelections();
                    }
                }
                else
                    lblResult.Text = "Make Selections First!";
            else
                lblResult.Text = "Make Selections First!";
        }

        private void TShirtSalesAppForm_Load(object sender, EventArgs e)
        {
            totalCost = 0;
            qtyArray = new ArrayList();
            sizeArray = new ArrayList();
        }

        private void ClearSelections()
        {
            lstBxSize.ClearSelected();
            cmboQuantity.SelectedIndex = 0;
        }
    }
}
