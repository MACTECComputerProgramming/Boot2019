/* CheckingAccount.cs   
 * This class extends BankAccount
 * by including details for checking account
 * customers.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    class CheckingAccount : BankAccount
    {
		private bool freeChecking;
		private bool freechecksProvided;
		private bool cancelledChecksReturned;
        private decimal checkingBalance;
        private decimal serviceCharge;
		
		public CheckingAccount()
			: base()
		{
		}

		public CheckingAccount(string lname, string fname, string id, bool freeCk, 
                                bool chkProv, bool cancelCks, 
                                decimal bal, decimal serviceCh)
			: base(lname, fname, id)
		{
			freeChecking = freeCk;
			freechecksProvided = chkProv;
			cancelledChecksReturned = cancelCks;
            checkingBalance = bal;
            serviceCharge = serviceCh;
 		}

        public CheckingAccount(string lname, string fname, string id, 
                                decimal bal, decimal serviceCh, decimal intRate)
            : base(lname, fname, id)
        {
            freeChecking = false;
            freechecksProvided = false;
            cancelledChecksReturned = false;
            checkingBalance = bal;
            serviceCharge = serviceCh;
        }
        
        // Property freeChecking
		public bool FreeChecking
		{
			get
			{
				return freeChecking;
			}
			set
			{
				freeChecking = value;
			}
		}

		public bool FreechecksProvided
		{
			get
			{
				return freechecksProvided;
			}
			set
			{
				freechecksProvided = value;
			}
		}

        public decimal ServiceCharge
        {
            get
            {
                return serviceCharge;
            }
            set
            {
                serviceCharge = value;
            }
        }

        public decimal CheckingBalance
        {
            get
            {
                return checkingBalance;
            }
            set
            {
                checkingBalance = value;
            }
        }

		public bool CancelledChecksReturned
		{
			get
			{
				return cancelledChecksReturned;
			}
			set
			{
				cancelledChecksReturned = value;
			}
		}

        public override string ToString()
        {
            return base.ToString() +
                "\nChecking Balance: " + checkingBalance.ToString("C") +
                "\nMonthly Service Charge: " + serviceCharge.ToString("C");
        }
	}
}
