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
                fileOut = new StreamWriter("../../info.txt"); // Relative path - File stored on top level in project - same level as bin
                // fileOut = new StreamWriter("info.txt"); // File stored in default directory (bin\debug directory)
                // fileOut = new StreamWriter("../../info.txt", true);  // add true to append records onto the end of the file.
            }
            catch (System.IO.IOException err)
            {
                MessageBox.Show(err.Message, "Error");
            }
        }

        private void btnStoreData_Click(object sender, EventArgs e)
        {
            string name;
            string address;
            long phone = 0;

            name = txtBxName.Text;
            address = txtBxEmail.Text;

            if (CheckPhone(ref phone))
            {
                fileOut.WriteLine(name + " " + address + "*" + phone + "*");
                MessageBox.Show("Your information has been written the a file.");
                ClearBox();
            }
        }

        private void ClearBox()
        {
            txtBxName.Clear();
            txtBxEmail.Clear();
            txtBxPhone.Clear();
            txtBxName.Focus();
        }

        private bool CheckPhone(ref long temp)
        {
            string phone = txtBxPhone.Text;
            bool correctPhone = true;
            try
            {
                temp = long.Parse(phone);
            }
            catch
            {
                MessageBox.Show("Invalid Phone Number-Just enter the digits");
                correctPhone = false;
                txtBxPhone.Clear();
            }
            return correctPhone;
        }

        private void FrmFileCreation_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
			{
				fileOut.Close();
			}
			catch (System.IO.IOException err)
			{
                MessageBox.Show(err.Message, "File close Error");				
			}
        }
    }
}
