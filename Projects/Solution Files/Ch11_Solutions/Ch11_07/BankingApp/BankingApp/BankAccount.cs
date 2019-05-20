/* BankAccount.cs
 * This class is the super (base) class for other types
 * of banking accounts. Checking and savings
 * accounts are derived from this account. 
 * The class includes common attributes associated
 * with banking accounts.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    class BankAccount
    {
        private string customerLastName;
        private string customerFirstName;
        private string customerID;
		
		public BankAccount()
		{
		}
        public BankAccount(string lname, string fname,
                            string id)
        {
            customerLastName = lname;
            customerFirstName = fname;
            customerID = id;
        }

        public BankAccount(string id)
        {
             customerID = id;
         
        }

     	public string ID
		{
			get
			{
				return customerID;
			}			
		}

        public string CustomerLastName
        {
            get 
            { 
                return customerLastName; 
            }
            set 
            { 
                customerLastName = value; 
            }
        }

		public string CustomerFirstName
		{
			get
			{
				return customerFirstName;
			}			
            set
            {
                customerFirstName = value;
            }
		}

        public override string ToString()
        {
            return "Name: " + customerFirstName + " " +
                        customerLastName + "\n" +
                    "Customer ID: " + customerID + "\n";
        }
	}
}

