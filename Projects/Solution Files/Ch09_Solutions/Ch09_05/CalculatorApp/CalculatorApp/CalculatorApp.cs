/* CalculatorApp.cs
 * This application allows the user
 * to input two numeric values. Buttons
 * for Add and Multiply are available which
 * display the results of the calculations.
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
    public partial class CalculatorAppForm : Form
    {
        public CalculatorAppForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double val1,
                    val2;

            val1 = GetFirstValue();
            val2 = GetSecondValue();
            
            if (val1 > 0 && val2 > 0)
            {
                lblResult.ForeColor = Color.Yellow;
                lblResult.Text = "Result = " + (val1 + val2).ToString();
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            double val1,
                   val2;

            val1 = GetFirstValue();
            val2 = GetSecondValue();

            if (val1 > 0 && val2 > 0)
            {
                lblResult.ForeColor = Color.Yellow;
                lblResult.Text = "Result = " + (val1 * val2).ToString();
            }

        }

        public double GetFirstValue()
        {
            double val1;

            while (double.TryParse(txtBxValue1.Text, out val1) == false)
            {
                lblResult.ForeColor = Color.Red;
                lblResult.Text = "Value must be numeric and > 0.";
                txtBxValue1.Text = "0";
                txtBxValue1.Focus();
            }
            return val1;
        }
  
        public double GetSecondValue()
        {
            double val2;
            while (double.TryParse(txtBxValue2.Text, out val2) == false)
            {
                lblResult.ForeColor = Color.Red;
                lblResult.Text = "Value must be numeric and > 0.";
                txtBxValue2.Text = "0";
                txtBxValue2.Focus();
            }
            return val2;
        }
    }
}
