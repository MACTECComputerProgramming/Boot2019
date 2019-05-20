/*BankAccountApp.cs
 * This application takes an account number and displays the 
 * current balance for that account.
 *
 * Can test the application with account number 101.
 * 
 
 * 
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

namespace BankAccountApp
{
    public partial class FrmBankApp : Form
    {
        public FrmBankApp()
        {
            InitializeComponent();
        }

        private void accountBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.accountBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.accountsDataSet);
            
        }

        private void FrmBankingAccount_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'accountsDataSet.Account' table. You can move, or remove it, as needed.
            this.accountTableAdapter.Fill(this.accountsDataSet.Account);
            this.txtBxBalance.Text = 0.ToString( );
        }

        private void btnToolStripRetrieve_Click(object sender, EventArgs e)
        {
            double amt;
            try
            {
                this.accountTableAdapter.FillByAccountNumber(accountsDataSet.Account,
                    txtBxAccNo.Text);
                if (txtBxBalance.Text != "")
                {
                    amt = double.Parse(txtBxBalance.Text);
                    txtBxBalance.Text = amt.ToString("C");
                    lblMessage.Text = "";
                }
                else
                {
                    lblMessage.Text = string.Format("Account number {0} not an active account!", txtBxAccNo.Text);
                    txtBxAccNo.Clear();
                    txtBxAccNo.Focus();
                }
            }
            catch (Exception exc)
            {
                lblMessage.Text = exc.Message;
            }
        }

    }
}
