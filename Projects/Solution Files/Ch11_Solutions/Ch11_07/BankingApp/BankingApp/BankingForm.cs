using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApp
{
    public partial class BankingForm : Form
    {
        CheckingAccount[] checkingCustomers;
        SavingsAccount[] savingsCustomers;
        public BankingForm()
        {
            InitializeComponent();
        }

        private void BankingForm_Load(object sender, EventArgs e)
        {
            checkingCustomers = new CheckingAccount[5];
            savingsCustomers = new SavingsAccount[3];

            checkingCustomers[0] = new CheckingAccount("York", "Susan", "1111234", true, true, true, 1000.00m, 3.00m);
            lstBxChecking.Items.Add(checkingCustomers[0].CustomerFirstName + " " + checkingCustomers[0].CustomerLastName);
            checkingCustomers[1] = new CheckingAccount("Abbott", "Charles", "2343223", true, false, false, 500.00m, 5.00m);
            lstBxChecking.Items.Add(checkingCustomers[1].CustomerFirstName + " " + checkingCustomers[1].CustomerLastName);
            checkingCustomers[2] = new CheckingAccount("Choo", "Chin", "2341237", true, true, true, 20.00m, 5.00m);
            lstBxChecking.Items.Add(checkingCustomers[2].CustomerFirstName + " " + checkingCustomers[2].CustomerLastName);
            checkingCustomers[3] = new CheckingAccount("Jacobs", "Jennifer", "3451237", true, true, true, 120.00m, 5.00m);
            lstBxChecking.Items.Add(checkingCustomers[3].CustomerFirstName + " " + checkingCustomers[3].CustomerLastName);
            checkingCustomers[4] = new CheckingAccount("White", "Keith", "8781237", true, true, true, 197.00m, 5.00m);
            lstBxChecking.Items.Add(checkingCustomers[4].CustomerFirstName + " " + checkingCustomers[4].CustomerLastName);

            savingsCustomers[0] = new SavingsAccount("Mitchell", "Claude", "2221231", 0.015m, 1000.00m, 2500.00m);
            lstBxSavings.Items.Add(savingsCustomers[0].CustomerFirstName + " " + savingsCustomers[0].CustomerLastName);
            savingsCustomers[1] = new SavingsAccount("Keen", "Antonio", "1113419", 0.015m, 1000.00m, 1200.00m);
            lstBxSavings.Items.Add(savingsCustomers[1].CustomerFirstName + " " + savingsCustomers[1].CustomerLastName);
            savingsCustomers[2] = new SavingsAccount("Acker", "Jerome", "1687999", 0.015m, 1000.00m, 1234.00m);
            lstBxSavings.Items.Add(savingsCustomers[2].CustomerFirstName + " " + savingsCustomers[2].CustomerLastName);
        }

        private void cmboTypeOfAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCustomers.Visible = true;
            if (cmboTypeOfAccount.SelectedIndex == 0)
            {
                lstBxSavings.Visible = true;
                lstBxChecking.Visible = false;
            }
            else
            {
                lstBxChecking.Visible = true;
                lstBxSavings.Visible = false;
            }
               
        }

        private void lstBxSavings_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(SavingsAccount customer in savingsCustomers)
            {
                if ((customer.CustomerFirstName + " " + customer.CustomerLastName) == lstBxSavings.SelectedItem.ToString())
                    MessageBox.Show(customer.ToString(), "Savings Account Customer");
            }
        }

        private void lstBxChecking_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (CheckingAccount customer in checkingCustomers)
            {
                if ((customer.CustomerFirstName + " " + customer.CustomerLastName) == lstBxChecking.SelectedItem.ToString())
                    MessageBox.Show(customer.ToString(), "Checking Account Customer");
            }

        }
    }
}
