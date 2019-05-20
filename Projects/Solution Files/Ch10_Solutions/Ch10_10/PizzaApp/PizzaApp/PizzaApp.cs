/* PizzaApp.cs
 * This application illustrates using
 * TabControls, ComboBoxes, Textboxes,
 * CheckListBox. Items can be ordered
 * with a total price displayed.
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

namespace PizzaApp
{
    public partial class PizzaForm : Form
    {
        private string order;
        private double totalCost;

        public PizzaForm()
        {
            InitializeComponent();
        }

        private void PizzaForm_Load(object sender, EventArgs e)
        {
            this.cmboSize.SelectedIndex = 1;
            this.cmboSauce.SelectedIndex = 0;
            this.cmboCrust.SelectedIndex = 0;
            this.cmboSpeciality.SelectedIndex = 0;
            this.cmboSauce.SelectedIndex = 0;
            this.cmboSpecialPizza.SelectedIndex = 0;
            this.txtBxSodaQty.Text = "0";
            this.txtBxWaterQty.Text = "0";
            order = "";
            totalCost = 0;
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            double drinkCost,
                   pizzaCost,
                   otherItemCost;
            order = "";
            order += cmboCrust.SelectedItem.ToString();
            order += " - ";
            order += cmboSize.SelectedItem.ToString();
            order += "\n";
            order += "Sauce: " + cmboSauce.SelectedItem.ToString();

            if (txtBxName.Text == "")
            {
                MessageBox.Show("Please provide Customer Info for delivery!", "B & D Pizza Express");
                tabControl1.SelectedTab = tabContactInfo;
            }
            else
            {
                if (lstBxToppings.SelectedItems.Count > 0)
                {
                    order += "\nToppings ($1.50 each):";
                    foreach (string s in lstBxToppings.SelectedItems)
                    {
                        order += "\n\t" + s;
                    }
                }

                pizzaCost = DeterminePizzaCost();

                if (cmboSpecialPizza.SelectedIndex != 0)
                {
                    order += "\nSpecialty pizza - Large $18.95 - ";
                    order += cmboSpecialPizza.SelectedItem;
                    pizzaCost += 18.95;
                }


                if (pizzaCost != 0)
                    order += "\n\nPizza Total: " + pizzaCost.ToString("C");

                drinkCost = DetermineDrinkCost();

                if (drinkCost != 0)
                    order += "\nDrink Total: " + drinkCost.ToString("C");

                otherItemCost = DetermineOtherItemCost();

                if (otherItemCost != 0)
                {
                    order += "\n\nSpecialty Items:\n" +
                            cmboSpeciality.SelectedItem.ToString();
                }
                order += "\n\nAmount Due: " + (pizzaCost + drinkCost + otherItemCost).ToString("C");
                order += "\n\n\nDeliver to: " + txtBxName.Text;
                if (txtBxAddress.Text != "")
                    order += ", " + txtBxAddress.Text;
                MessageBox.Show(order, "B & D Pizza Express Order\n");
            }
        }
   
        private double DetermineDrinkCost()
        {
            double sodaCnt,
                   waterCnt;
            totalCost = 0;
            if (txtBxSodaQty.Text != "")
            {
                while (double.TryParse(txtBxSodaQty.Text, out sodaCnt) == false)
                {
                    lblErrorMsg.Text = "Quantity must be numeric";
                    txtBxSodaQty.Text = "0";
                }
                order += "\n\nDrink Selections:\n" + sodaCnt + " soda(s)"; 
                totalCost = sodaCnt * 1.75;
            }
            if (txtBxWaterQty.Text != "")
            {
                while (double.TryParse(txtBxWaterQty.Text, out waterCnt) == false)
                {
                    lblErrorMsg.Text = "Quantity must be numeric";
                    txtBxWaterQty.Text ="0";
                }
                order += "\n" + waterCnt + " water(s)"; 
            }
            return totalCost;
        }

        public double DeterminePizzaCost()
        {
            double cost;
            if (cmboSize.SelectedIndex == 0)
                cost = 9.95;
            else
                if (cmboSize.SelectedIndex == 1)
                    cost = 12.95;
                else
                    cost = 15.95;
            return cost + (lstBxToppings.SelectedItems.Count * 1.50);
        }

        public double DetermineOtherItemCost()
        {
            double cost;

            if (cmboSpeciality.SelectedIndex == 1)
            {
                cost = 5.00;
            }
            else
                if (cmboSpeciality.SelectedIndex == 2)
                {
                    cost = 4.00;
                }
                else
                    if (cmboSpeciality.SelectedIndex == 3)
                    {
                        cost = 3.00;
                    }
                    else
                        cost = 0;
            return cost;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.cmboSize.SelectedIndex = 1;
            this.cmboSauce.SelectedIndex = 0;
            this.cmboCrust.SelectedIndex = 0;
            this.cmboSpeciality.SelectedIndex = 0;
            this.cmboSauce.SelectedIndex = 0;
            this.cmboSpecialPizza.SelectedIndex = 0;
            this.lstBxToppings.ClearSelected();
            txtBxAddress.Text = "";
            txtBxName.Text = "";
            txtBxEmail.Text = "";
            txtBxPhone.Text = "";
            this.txtBxSodaQty.Text = "0";
            this.txtBxWaterQty.Text = "0";
            order = "";
            totalCost = 0;
            tabControl1.SelectedTab = tabPizza;
        }
    }
}
