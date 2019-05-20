/*  PasswordApp.cs
 * This program asks the user to 
 * input a password. A second password
 * is entered. The program checks 
 * to see if the passwords are the same.
 * The program then displays a 
 * message indicating whether the words
 * are the same or not. 
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

namespace PasswordApp
{
    public partial class PasswordAppForm : Form
    {
        public PasswordAppForm()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            lblMessage.Visible = true;
            lblPass2.Visible = true;
            txtBxPass2.Visible = true;
            txtBxPass2.Focus();
            btnCheck.Visible = true;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (txtBxPass1.Text == txtBxPass2.Text)
                lblMessage.Text = "Passwords are the same!";
            else
                lblMessage.Text = "Passwords are different!";
            btnReset.Visible = true;

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBxPass1.Clear();
            lblMessage.Visible = false;
            lblPass2.Visible = false;
            txtBxPass2.Visible = false;
            txtBxPass1.Focus();
            btnCheck.Visible = false;
            btnReset.Visible = false;
        }


    }
}
