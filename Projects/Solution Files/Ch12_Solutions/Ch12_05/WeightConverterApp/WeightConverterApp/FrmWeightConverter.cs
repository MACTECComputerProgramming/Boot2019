using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeightConverterApp
{
    public partial class FrmWeightConverter : Form
    {
        WeightConverter newMeasurement;

        public FrmWeightConverter()
        {
            InitializeComponent();
        }

        private void cmboFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                newMeasurement = new WeightConverter
                    (double.Parse(txtBxUnits.Text), cmboFrom.SelectedItem.ToString());
                lblTo.Visible = true;
                cmboTo.Visible = true;
            }
            catch (ArithmeticException ex)
            {
                MessageBox.Show(ex.Message);
            }

            catch (FormatException ex)
            {
                MessageBox.Show("Number format problem - " + ex.Message);

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmboTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmboFrom.Text == "")
                {
                    throw new Exception("Error: No units selected");
                }
                if (txtBxUnits.Text == "")
                {
                    throw new Exception("Error: No number entered");
                }
                else
                {
                    newMeasurement.NewUnitOfMeasurement = cmboTo.SelectedItem.ToString();
                    lblResults.Text = newMeasurement.ToString();
                }
                
                            
            }
            catch(Exception c)
            {
                MessageBox.Show(c.Message, "Error: NonNumber");
                
            }
        }

        private void FrmWeightConverter_Load(object sender, EventArgs e)
        {
            cmboFrom.SelectedIndex = -1;
        }
    }
}
