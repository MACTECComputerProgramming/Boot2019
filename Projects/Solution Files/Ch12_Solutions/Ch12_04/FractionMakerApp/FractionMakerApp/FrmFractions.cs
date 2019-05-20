/* This application tests the Fraction class.
 * */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractionMakerApp
{
    public partial class FrmFractions : Form
    {
        Fraction testFraction;

        public FrmFractions()
        {
            InitializeComponent();
        }

        private void FrmFractions_Load(object sender, EventArgs e)
        {
            txtBxNumerator.Focus();
        }

        private void btnMakeFraction_Click(object sender, EventArgs e)
        {
            try
            {
                int num = int.Parse(txtBxNumerator.Text);
                int denom = int.Parse(txtBxDenominator.Text);


                testFraction = new Fraction(num, denom);

                lblResult.Text = "Your fraction is " + testFraction.ToString() + "\nwith an approximate value of " +
                    testFraction.CalculateDecimalValue().ToString("0.000");

                testFraction.Reduce();
                if (testFraction.Numerator != num && testFraction.Denominator != denom)
                {
                        lblResult.Text += "\nAnd it reduces to " + testFraction.Numerator + "/" + testFraction.Denominator;
                }
            }
            catch (Exception c)
            {
                MessageBox.Show(c.Message);
            }

        }
    }
}
