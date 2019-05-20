/* FrmFileAccess.cs   
 * This application reads
 * integers from a text file,
 * displays the number of values,
 * the average, smallest and largest
 * value.
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
using System.IO;

namespace FileAccessApp
{
    public partial class FrmFileAccess : Form
    {
        private StreamReader inFile;
        private int[] numbers;

        public FrmFileAccess()
        {
            InitializeComponent();
        }

        private void FrmFileAccess_Load(object sender, EventArgs e)
        {
            string inValue;
            numbers = new int[20];
            int i = 0;

            if (File.Exists("numbers.txt"))
            {
                try
                {
                    inFile = new StreamReader("numbers.txt");
                    while ((inValue = inFile.ReadLine()) != null)
                    {
                        numbers[i] += int.Parse(inValue);
                        i++;
                    }
                    lblResult.Text = "Number of values in file: " + i;
                }

                catch (System.IO.IOException exc)
                {
                    lblResult.Text = exc.Message;
                }
            }

            else
            {
                lblResult.Text = "File Unavailable";
            }

            lblResult.Visible = true;
        }

        private void FrmFileAccess_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                inFile.Close();
            }

            catch (Exception ex)
            {
                lblResult.Text = ex.Message;
            }
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            double total = 0;
            foreach (int val in numbers)
                total += val;
            lblResult.Text = "Average value: " + 
                (total / numbers.Length).ToString("F2");
        }

        private void btnSmallest_Click(object sender, EventArgs e)
        {
            double smallest = numbers[0];
            foreach (int val in numbers)
                if (val < smallest)
                    smallest = val;
            lblResult.Text = "Smallest value: " + smallest;
        }

        private void btnLargest_Click(object sender, EventArgs e)
        {
            double largest = numbers[0];
            foreach (int val in numbers)
                if (val > largest)
                    largest = val;
            lblResult.Text = "Largest value: " + largest;
        }
    }
}