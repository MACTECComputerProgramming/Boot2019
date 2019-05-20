/*SportsForm.cs
 * This application enables users to
 * sign up for one of five sports. Once
 * selections are made, a picture is
 * displayed along with an apprporiate 
 * message.
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

namespace SportsSignUpApp
{
    public partial class SportsForm : Form
    {
        public SportsForm()
        {
            InitializeComponent();
        }

        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            picLogo.Visible = false;
            picBaseBall.Visible = false;
            picBasketball.Visible = false;
            picSoccer.Visible = false;
            picSwim.Visible = false;
            picTennis.Visible = false;


            if (radBaseball.Checked)
            {
                picBaseBall.Visible = true;
                lblMessage.Text = "You must bring your own bat.";
            }
            else
                if (radBasketball.Checked)
                {
                    picBasketball.Visible = true;
                    lblMessage.Text = "Practice 3 days per week.";

                }
                else
                    if (radSoccer.Checked)
                    {
                        picSoccer.Visible = true;
                        lblMessage.Text = "Transportation provided to the field.";

                    }
                    else
                        if (radSwim.Checked)
                        {
                            picSwim.Visible = true;
                            lblMessage.Text = "No lifeguard on duty during practice!";

                        }
                        else
                            if (radTennis.Checked)
                            {
                                picTennis.Visible = true;
                                lblMessage.Text = "Sign for singles or double, but not both.";

                            }
        }

        private void SportsForm_Load(object sender, EventArgs e)
        {
            picLogo.Visible = true;
        }

    }
}
