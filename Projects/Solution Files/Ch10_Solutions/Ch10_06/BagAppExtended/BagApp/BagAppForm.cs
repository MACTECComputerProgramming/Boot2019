/* BagApp.cs 
 * This application allows users to
 * select from a list of bags to order.
 * The one selected along with the
 * quantity desired are displayed. 
 * Shipping charges are calculated and
 * the total due is displayed. A
 * reset button allows selections to
 * be cleared.
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

namespace BagApp
{
    public partial class BagForm : Form
    {
        public BagForm()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstBxSelection.ClearSelected();
            cmboQty.Text = "";
            lblErrorMsg.Text = "";
            radStandard.Checked = true;
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            double price,
                   totalCostBeforeShipping,
                   shippingCharge,
                   total;
            if (lstBxSelection.SelectedIndices.Count != 0)
            {
                if (cmboQty.SelectedIndex > 0)
                {
                    
                    lblErrorMsg.Text = "";
                    price = GetPrice();
                    totalCostBeforeShipping = price * int.Parse(cmboQty.SelectedItem.ToString());
                    shippingCharge = GetShippingCost(totalCostBeforeShipping);
                    total = shippingCharge + totalCostBeforeShipping;
                    MessageBox.Show("  Items to Order\n  --------------\nBag Type: " +
                            lstBxSelection.SelectedItem +
                            "\nQuantity: " + cmboQty.SelectedItem +
                            "\nShipping Charges: " + shippingCharge.ToString("C") +
                            "\nTotal Cost: " + total.ToString("C"), 
                            "Bag App");
                }
                else
                    lblErrorMsg.Text = "Please make selection from above!";
            }
            else
                lblErrorMsg.Text = "Please make selection from above!";
            
        }
        private double GetPrice()
        {
            string price;
            int indexLocationOfDollarSymbol;

            price = lstBxSelection.SelectedItem.ToString();
            indexLocationOfDollarSymbol = price.IndexOf('$');
            price = price.Substring(indexLocationOfDollarSymbol + 1, 2);
            return double.Parse(price);
        }

        private void BagForm_Load(object sender, EventArgs e)
        {
            radStandard.Checked = true; ;
        }

        private double GetShippingCost(double totalCostBeforeShipping)
        {
            double shipPercent = 0;
            if (radStandard.Checked)
                shipPercent = 0.05;
            else
                if (rad3Day.Checked)
                    shipPercent = 0.07;
                else
                    if (radOvernight.Checked)
                        shipPercent = 0.10;
            return totalCostBeforeShipping * shipPercent;
        }
    }
}
