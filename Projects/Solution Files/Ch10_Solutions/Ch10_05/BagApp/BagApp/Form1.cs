/* BagApp.cs 
 * This application allows users to
 * select from a list of bags to order.
 * The one selected along with the
 * quantity desired are displayed. A
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
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (lstBxSelection.SelectedIndices.Count != 0)
            {
                if (cmboQty.SelectedIndex > 0)
                {
                    lblErrorMsg.Text = "";
                    MessageBox.Show("  Items to Order\n  --------------\nBag Type: " +
                            lstBxSelection.SelectedItem +
                            "\nQuantity: " + cmboQty.SelectedItem, "Bag App");
                }
                else
                    lblErrorMsg.Text = "Please make selection from above!";
            }
            else
                lblErrorMsg.Text = "Please make selection from above!";
            
        }

    }
}
