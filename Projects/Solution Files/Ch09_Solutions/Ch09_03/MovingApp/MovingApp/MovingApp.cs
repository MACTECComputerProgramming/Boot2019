/* MovingApp.cs
 * This programs asks the user to 
 * enter two coordinates and then
 * moves the form to that location
 * on the screen.
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

namespace MovingApp
{
    public partial class MovingAppForm : Form
    {
        public MovingAppForm()
        {
            InitializeComponent();
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            int x,
                y;
            while (int.TryParse(txtBxX.Text, out x) == false)
            {
                lblErrorMsg.Text = "Value entered must be numeric";
                txtBxX.Text = "0";
                txtBxX.Focus();
            }

            while (int.TryParse(txtBxY.Text, out y) == false)
            {
                lblErrorMsg.Text = "Value entered must be numeric";
                txtBxY.Text = "0";
                txtBxY.Focus();
            }

            if (txtBxX.Text != "0")
                if (txtBxY.Text != "0")
                    Location = new Point(x, y);
        }
    }
}