/* BMI_Calculator.cs
 * This application allows users to input their
 * weight and height. BMI is calculated using 
 * those values. 
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

namespace BMI_Calculator
{
    public partial class FrmBMI : Form
    {
        BodyMassIndexCalculator bmi;
        public FrmBMI()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                bmi = new BodyMassIndexCalculator(int.Parse(txtBxWeight.Text), int.Parse(txtBxHeightFt.Text),
                                                    int.Parse(txtBxHeightInches.Text));
                lblResult.Text = bmi.ToString();
            }

            catch (ArithmeticException exc)
            {
                MessageBox.Show("Arithmetic Problem - " + exc.Message);
            }
            catch (FormatException exc)
            {
                MessageBox.Show("Number Format Problem - " + exc.Message);
            }

            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }
    }
}
