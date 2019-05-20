/*SkiSignUpApp.cs
 * This application enables users
 * to sign up for equipment for an
 * upcoming skiing event. Menu options
 * are available to display and clear
 * selections.
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

namespace SkiSignUpApp
{
    public partial class SkiSignUpForm : Form
    {
        public SkiSignUpForm()
        {
            InitializeComponent();
        }

        private void menuDisplay_Click(object sender, EventArgs e)
        {
            string result = "\tItems Needed\n\t------------\n\n";

            if (ckBxEarmuffs.Checked)
                result += "\t  " + ckBxEarmuffs.Text + "\n";
            if (ckBxGoggles.Checked)
                result += "\t  " + ckBxGoggles.Text + "\n";
            if (ckBxBindings.Checked)
                result += "\t  " + ckBxBindings.Text + "\n";
            if (ckBxBoots.Checked)
                result += "\t  " + ckBxBoots.Text + "\n";
            if (ckBxSkis.Checked)
                result += "\t  " + ckBxSkis.Text + "\n";
            if (ckBxPoles.Checked)
                result += "\t  " + ckBxPoles.Text + "\n";
            if (ckBxGloves.Checked)
                result += "\t  " + ckBxGloves.Text + "\n";


            MessageBox.Show(result, "Flyer Sports Club - Ski Outting");
        }

        private void menuClear_Click(object sender, EventArgs e)
        {
            ckBxEarmuffs.Checked = false;
            ckBxGoggles.Checked = false;
            ckBxBindings.Checked = false;
            ckBxBoots.Checked = false;
            ckBxSkis.Checked = false;
            ckBxPoles.Checked = false;
            ckBxGloves.Checked = false;
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
