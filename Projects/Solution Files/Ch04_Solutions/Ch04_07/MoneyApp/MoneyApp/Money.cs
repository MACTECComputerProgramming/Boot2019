/* Money.cs 
 * This class has two private data members representing
 * dollars and cents. Constructors are available to 
 * instantiate the class with 2 integers or a single
 * decimal value. Increment and Decrement methods are
 * included.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyApp
{
    class Money
    {
        private int dollars;
        private int cents;
        private decimal fullAmount;

        public Money()
        {
        }

        public Money(int d, int c)
        {
            cents = c;
            dollars = d;
        }

        public Money(decimal amount)
        {
            fullAmount = amount;
            dollars = (int)(amount * 100) / 100;
            cents = (int)(amount * 100);
            cents = cents % 100;
        }

        public int Dollars
        {
            get
            {
                return dollars;
            }
            set
            {
                dollars = value;
            }
        }

        public int Cents
        {
            get
            {
                return cents;
            }
            set
            {
                cents = value;
            }
        }

        public decimal FullAmount
        {
            get
            {
                return fullAmount;
            }
            set
            {
                fullAmount = value;
            }
        }

        public string ReturnChange()
        {
            int quarters,
                dimes,
                nickels,
                pennies,
                leftOver;

            quarters = cents / 25;
            leftOver = cents % 25;
            dimes = leftOver / 10;
            leftOver = leftOver % 10;
            nickels = leftOver / 5;
            pennies = leftOver % 5;

            return "Dollars: " + dollars +
                   "\nQuarters: " + quarters +
                   "\nDimes: " + dimes +
                   "\nNickels: " + nickels +
                   "\nPennies: " + pennies;
        }

        public void IncrementMoney(decimal amount)
        {
            decimal newValue,
                    dollarAmount;

            dollarAmount = ConvertToOneNumber();
            newValue = dollarAmount + amount;
            GetNewDollarsAndCents(newValue);
        }

        public void DecrementMoney(decimal amount)
        {
            decimal newValue,
                    dollarAmount;
            dollarAmount = ConvertToOneNumber();
            newValue = dollarAmount - amount;
            GetNewDollarsAndCents(newValue);
        }

        public decimal ConvertToOneNumber()
        {
            decimal dollarAmount;
            dollarAmount = dollars + (cents / 100.0M);
            return dollarAmount;
        }

        public void GetNewDollarsAndCents(decimal newValue)
        {
            dollars = (int)(newValue * 100) / 100;
            cents = (int)(newValue * 100);
            cents = cents % 100;
        }

        public override string ToString()
        {
            return ConvertToOneNumber().ToString("C");
        }
    }
}
