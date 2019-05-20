/* NumberProcessor.cs
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

namespace NumberProcessor
{
    public partial class FrmNumberProcessor : Form
    {
        public FrmNumberProcessor()
        {
            InitializeComponent();
        }

        private void FrmNumberProcessor_Load(object sender, EventArgs e)
        {
            txtBxValue1.Focus();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
             try
            {
                lstBxValue1.Items.Add(int.Parse(txtBxValue1.Text));
                lstBxValue2.Items.Add(int.Parse(txtBxValue2.Text));
                lstBxResult.Items.Add(int.Parse(txtBxValue2.Text) * int.Parse(txtBxValue1.Text));
                txtBxValue1.Clear();
                txtBxValue2.Clear();
                txtBxValue1.Focus();
            }

            catch (IndexOutOfRangeException exc)
            {
                MessageBox.Show(exc.Message);
            }

            catch (System.FormatException exc)
            {
                MessageBox.Show(exc.Message, "Invalid number format");
            }

            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
        }
        }

    }

