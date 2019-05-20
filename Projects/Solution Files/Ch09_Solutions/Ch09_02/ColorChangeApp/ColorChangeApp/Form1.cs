/* ColorChangeApp.cs
 * This application enables the user
 * to change the color of the form
 * dynamically. The color selection
 * is displayed.
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

namespace ColorChangeApp
{
    public partial class ColorChangeAppForm : Form
    {
        public ColorChangeAppForm()
        {
            InitializeComponent();
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Green;
            MessageBox.Show("Color selection was: " + BackColor);
        }

        private void btnGray_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Gray;
            MessageBox.Show("Color selection was: " + BackColor);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Blue;

        }
    }
}
