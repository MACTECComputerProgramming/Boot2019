/* FormCalculator.cs
 * This application works with
 * integer values. An exception is
 * thrown if division by zero is
 * attempted.
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

namespace CalculatorApp
{
    public partial class FormCalculator : Form
    {
        public string operation = "";
        public double number;
        public bool locknum;

        public FormCalculator()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (locknum == false)
                txtNumbers.Text += "1";
            else
            {
                txtNumbers.Text = "1";
                locknum = false;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (locknum == false)
                txtNumbers.Text += "2";
            else
            {
                txtNumbers.Text = "2";
                locknum = false;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (locknum == false)
                txtNumbers.Text += "3";
            else
            {
                txtNumbers.Text = "3";
                locknum = false;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (locknum == false)
                txtNumbers.Text += "4";
            else
            {
                txtNumbers.Text = "4";
                locknum = false;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (locknum == false)
                txtNumbers.Text += "5";
            else
            {
                txtNumbers.Text = "5";
                locknum = false;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (locknum == false)
                txtNumbers.Text += "6";
            else
            {
                txtNumbers.Text = "6";
                locknum = false;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (locknum == false)
                txtNumbers.Text += "7";
            else
            {
                txtNumbers.Text = "7";
                locknum = false;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (locknum == false)
                txtNumbers.Text += "8";
            else
            {
                txtNumbers.Text = "8";
                locknum = false;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (locknum == false)
                txtNumbers.Text += "9";
            else
            {
                txtNumbers.Text = "9";
                locknum = false;
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (locknum == false)
                txtNumbers.Text += "0";
            else
            {
                txtNumbers.Text = "0";
                locknum = false;
            }
        }

        private void btnNeg_Click(object sender, EventArgs e)
        {
            try
            {
                double temp = double.Parse(txtNumbers.Text);
                temp = -1 * temp;
                txtNumbers.Text = temp.ToString();
            }
            catch (Exception c)
            {
                MessageBox.Show(c.Message, "Error: Enter a number before hitting this button");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (operation != "")
            {
                btnEquals_Click(sender, e);
                operation = "+";
                locknum = true;
            }
            else
            {
                operation = "+";
                number = double.Parse(txtNumbers.Text);
                txtNumbers.Text = "";
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            try
            {

                if (operation == "+")
                    number = number + double.Parse(txtNumbers.Text);
                else
                    if (operation == "-")
                        number = number - double.Parse(txtNumbers.Text);
                    else
                        if (operation == "x")
                            number = number * double.Parse(txtNumbers.Text);
                        else
                            if (operation == "/")
                                if (double.Parse(txtNumbers.Text) == 0)
                                {
                                    throw new DecimalDivideZeroException("Error: Divide by Zero");
                                }
                                else
                                    number = number / double.Parse(txtNumbers.Text);
                operation = "";
                txtNumbers.Text = number.ToString();
            }
            catch (Exception c)
            {
                MessageBox.Show(c.Message, "Error");
            }
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            if (operation != "")
            {
                btnEquals_Click(sender, e);
                operation = "-";
                locknum = true;
            }
            else
            {
                operation = "-";
                number = double.Parse(txtNumbers.Text);
                txtNumbers.Text = "";
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (operation != "")
            {
                btnEquals_Click(sender, e);
                operation = "x";
                locknum = true;
            }
            else
            {
                operation = "x";
                number = double.Parse(txtNumbers.Text);
                txtNumbers.Text = "";
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (operation != "")
            {
                btnEquals_Click(sender, e);
                operation = "/";
                locknum = true;
            }
            else
            {
                operation = "/";
                number = double.Parse(txtNumbers.Text);
                txtNumbers.Text = "";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            number = 0;
            txtNumbers.Text = "";
            operation = "";
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (locknum == false)
                txtNumbers.Text += ".";
            else
            {
                txtNumbers.Text = ".";
                locknum = false;
            }
        }
    }
}
