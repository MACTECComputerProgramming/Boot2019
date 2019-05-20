/* InputForm.cs
 * This application enables users
 * to enter personal information on
 * a windows form. Menu options are
 * provided to process the data, clear
 * the form and exit.
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

namespace InputForm
{
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
        }

        private void  exitMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
         
        private void aboutmenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Input Form", "Developed by Barbara Doyle\n\nVersion 1.0");
        }

        private void processMenu_Click(object sender, EventArgs e)
        {
            string output;

            output = txtBxName.Text + "\n" +
                txtBxEmail.Text + "\n" +
                txtBxPhone.Text;
            MessageBox.Show(output, "Personal Data");
        }

        private void clearMenu_Click(object sender, EventArgs e)
        {
            txtBxName.Clear();
            txtBxEmail.Clear();
            txtBxPhone.Clear();
        }
    }
}
