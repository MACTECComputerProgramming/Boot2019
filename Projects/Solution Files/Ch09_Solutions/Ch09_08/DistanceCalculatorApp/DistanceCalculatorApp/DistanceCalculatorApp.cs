/* DistanceCalculatorApp.cs
 * This application enables users to input
 * time and speed. It calculates and 
 * displays distance traveled.
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

namespace DistanceCalculatorApp
{
    public partial class DistanceCalculatorForm : Form
    {
        public DistanceCalculatorForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            double speed,
                   time;
                
            while (double.TryParse(txtBxSpeed.Text, out speed) == false)
            {
                lblAnswer.Text = "Speed must be a positive numeric value";
                txtBxSpeed.Text = "0";
                txtBxSpeed.Focus();
            }

            while (double.TryParse(txtBxTime.Text, out time) == false)
            {
                lblAnswer.Text = "Speed must be a positive numeric value";
                txtBxTime.Text = "0";
                txtBxTime.Focus();
            }
            if (time != 0 && speed != 0)
                lblAnswer.Text = "Traveled: " + (time * speed).ToString("F1") + " Miles";
        }

        private void DistanceCalculatorForm_Load(object sender, EventArgs e)
        {
            txtBxSpeed.Focus();
        }
    }
}
