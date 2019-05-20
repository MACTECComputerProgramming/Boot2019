/* QuoteForm.cs
 * This application lets user select from
 * a list of favorite sayings. An option is
 * available to allow the user to type in
 * their favorite saying. The color and
 * font can be changed when the message is
 * displayed.
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

namespace Quoter
{
    public partial class QuoteForm : Form
    {
        public QuoteForm()
        {
            InitializeComponent();
        }

        private void cmboQuote_SelectedIndexChanged(object sender, EventArgs e)
        {

            lblMessage.Text = cmboQuote.SelectedItem.ToString();
        }

        private void cmboQuote_TextUpdate(object sender, EventArgs e)
        {
            lblMessage.Text = cmboQuote.Text;
        }

        private void fontMenu_Click(object sender, EventArgs e)
        {
            fontDialogOption.Font = lblMessage.Font;
            if (fontDialogOption.ShowDialog() != DialogResult.Cancel)
            {
                lblMessage.Font = fontDialogOption.Font;
            }
        }

        private void colorMenu_Click(object sender, EventArgs e)
        {
            colorDialogOption.Color = lblMessage.ForeColor;
            if (colorDialogOption.ShowDialog() != DialogResult.Cancel)
            {
                lblMessage.ForeColor = colorDialogOption.Color;
            }
        }

        private void aboutMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Favorite Quotes\nVersion 1.0\nDesigner: Barbara Doyle",
                                "Favorite Quote App", MessageBoxButtons.OK, 
                                MessageBoxIcon.Information);
        }

        private void exitMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
