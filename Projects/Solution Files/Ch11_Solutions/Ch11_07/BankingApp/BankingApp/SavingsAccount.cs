/* This class extends BankAccount
 * providing details regarding
 * savings account objects. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    class SavingsAccount : BankAccount
    {
        private decimal interestRate;
		private decimal minBalance;
		private decimal savingsBalance;
		
		public SavingsAccount()
			: base()
		{
		}

		public SavingsAccount(string customerLastName, string customerFirstName, 
                                string id, decimal intRate, decimal minimumBal, 
                                decimal thebalance)
			: base(customerLastName, customerFirstName, id)
		{
			interestRate = intRate;
			minBalance = minimumBal;
			savingsBalance = thebalance;
		}

		// Property interestRate
		public decimal InterestRate
		{
			get
			{
				return interestRate;
			}
			set
			{
				interestRate = value;
			}
		}

		// Property minBalance
		public decimal MinBalance
		{
			get
			{
				return minBalance;
			}
			set
			{
				minBalance = value;
			}
		}

		// Property balance
		public decimal Balance
		{
			get
			{
				return savingsBalance;
			}
			set
			{
				savingsBalance = value;
			}
		}

        public override string ToString()
        {
            return base.ToString() +
                "\nSavings Balance: " + savingsBalance.ToString("C") +
                "\nInterest Rate: " + interestRate.ToString("P2");
        }
	}
}
