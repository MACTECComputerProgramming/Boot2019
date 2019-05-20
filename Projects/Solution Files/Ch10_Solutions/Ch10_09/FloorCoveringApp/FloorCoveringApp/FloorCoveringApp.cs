using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FloorCoveringApp
{
    public partial class FloorCoveringAppForm : Form
    {
        public FloorCoveringAppForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double noSqYds,
                   price;
            string result;
            
            noSqYds = GetDimensions();
            string selection;

            if (tabControl1.SelectedIndex == 0)
                selection = cmboCarpetType.SelectedItem.ToString();
            else
                if (tabControl1.SelectedIndex == 1)
                    selection = cmboHardwoodType.SelectedItem.ToString();
                else
                    selection = cmboLaminateType.SelectedItem.ToString();

            price = DeterminePrice(selection);
            result =
                    "Selection: " + 
                     tabControl1.SelectedTab.Text +
                     " - " +
                     selection +
                     "\nSquare Yards Needed: " + 
                     noSqYds.ToString("F2") +
                     "\nTotal Cost: " + 
                     (price * noSqYds).ToString("C");

             // Don't display output, if there is a problem with input
             if (noSqYds != 0)
                if (lblErrorMsg.Text == "")
                    MessageBox.Show(result,"Flooring App");

        }

        public double GetDimensions()
        {
            double widthFeet = 0,
                   widthInches = 0,
                   lengthFeet = 0,
                   lengthInches = 0,
                   sqYards;
         
                while (double.TryParse(txtBxWidthFeet.Text, out widthFeet) == false)
                {
                    lblErrorMsg.Text = "Only numeric data can be entered";
                    txtBxWidthFeet.Text = "0".ToString();
                    txtBxWidthFeet.Focus();
                }   

                while (double.TryParse(txtBxLengthFeet.Text, out lengthFeet) == false)
                {
                    lblErrorMsg.Text = "Only numeric data can be entered";
                    txtBxLengthFeet.Text = "0";
                    txtBxLengthFeet.Focus();
                }

                while (double.TryParse(txtBxWidthInches.Text, out widthInches) == false)
                {
                    lblErrorMsg.Text = "Only numeric data can be entered";
                    txtBxWidthInches.Text = "0".ToString();
                    txtBxWidthInches.Focus();
                }
            
                while (double.TryParse(txtBxLengthInches.Text, out lengthInches) == false)
                {
                    lblErrorMsg.Text = "Only numeric data can be entered";
                    txtBxLengthInches.Text = "0";
                    txtBxLengthInches.Focus();
                }
                if (widthFeet != 0 && lengthFeet != 0)
                    sqYards = ((widthFeet + (widthInches / 12)) * (lengthFeet + (lengthInches / 12))) / 9.0;
                else
                    sqYards = 0;
            return sqYards;
        }


        private void txtBxWidthFeet_MouseEnter(object sender, EventArgs e)
        {
            lblErrorMsg.Text = "";
        }

        private void txtBxLengthFeet_MouseEnter(object sender, EventArgs e)
        {
            lblErrorMsg.Text = "";
        }

        private void txtBxWidthInches_MouseEnter(object sender, EventArgs e)
        {
            lblErrorMsg.Text = "";
        }

        private void txtBxLengthInches_MouseEnter(object sender, EventArgs e)
        {
            lblErrorMsg.Text = "";
        }

        private double DeterminePrice(string selection)
        {
            int locationOfDollarSymbol;
            string price;

            locationOfDollarSymbol = selection.IndexOf('$');
            price = selection.Substring(locationOfDollarSymbol + 1, 5);
            return double.Parse(price); 
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBxLengthFeet.Text = "0";
            txtBxLengthInches.Text = "0";
            txtBxWidthFeet.Text = "0";
            txtBxWidthInches.Text = "0";
            cmboCarpetType.SelectedIndex = 0;
            cmboHardwoodType.SelectedIndex = 0;
            cmboLaminateType.SelectedIndex = 0;
            lblErrorMsg.Text = "";
        }

    }
}
