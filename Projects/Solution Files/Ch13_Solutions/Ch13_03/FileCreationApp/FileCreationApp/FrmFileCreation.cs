/* FrmFileCreation.cs
 * Displays a GUI that enables the user
 * to input name, address and phone
 * numbers. Phone is delimited with
 * asterisks. Values
 * are stored to a file. 
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

namespace FileCreationApp
{
    public partial class FrmFileCreation : Form
    {
        private StreamWriter fileOut;

        public FrmFileCreation()
        {
            InitializeComponent();
        }

        private void FrmFileCreation_Load(object sender, EventArgs e)
        {
            try
            {
                fileOut = new StreamWriter("info.txt");    // File stored in bin\debug directory
            }
            catch (System.IO.IOException err)
            {
                lblMessage.Text = err.Message;
            }
        }

        private void btnStoreData_Click(object sender, EventArgs e)
        {
            string phoneNumber = txtBxPhone.Text.Replace("-", "");

            fileOut.WriteLine(txtBxName.Text + " " + txtBxAddress.Text + "*" + phoneNumber + "*");
            lblMessage.Text = "Your information has been written to the file.";
        }

        private void FrmFileCreation_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                fileOut.Close();
            }
            catch (System.IO.IOException err)
            {
                lblMessage.Text = err.Message + "File close Error";
            }
        }
    }
}
