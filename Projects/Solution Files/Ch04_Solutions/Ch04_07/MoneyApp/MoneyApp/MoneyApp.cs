/* MoneyApp.cs
 * This class tests the Money class
 * by instantiating several objects, using Money's
 * properties and calling 
 * methods that converts the cents into dollars
 * and dollars into cents.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyApp
{
    class MoneyApp
    {
        static void Main(string[] args)
        {
            decimal amountToChange;
            Money firstMoney = new Money();
            firstMoney.Dollars = 5;
            firstMoney.Cents = 36;
            Console.WriteLine("Original Amount --  " + firstMoney.Dollars + " Dollars " + firstMoney.Cents + " Cents");
            Console.WriteLine();
            Console.Write("Enter decrement amount -- ");

            amountToChange = AskForFullDollarAmount();

            Console.Clear();
            Console.WriteLine("\tDecrement Test");
            Console.WriteLine("\nOriginal Amount: " + firstMoney.ToString());
            firstMoney.DecrementMoney(amountToChange);

            Console.WriteLine("Amount to Subtract: " + amountToChange.ToString("F2") +
                                "\n\tNew Dollar Amount: " + firstMoney.Dollars.ToString("F2") +
                               "\n\tNew Cent Amount: " + "." + firstMoney.Cents +
                               "\n\tNew Full Amount: " + firstMoney.ToString());
            Console.WriteLine("Press any key to see the next test......");
            Console.ReadKey();

            Console.Clear();
            Money nextMoneyTest = new Money(4, 2);
            Console.WriteLine("\nSecond Test: ");
            Console.WriteLine("\nNext Money Value: " + nextMoneyTest);
            Console.WriteLine("Enter Increment amount (with decimal for cents).");
            amountToChange = AskForFullDollarAmount();

            Console.Clear();
            Console.WriteLine("\nSecond Test: ");
            Console.WriteLine("Original Amount --  " + nextMoneyTest.Dollars + " Dollars " + nextMoneyTest.Cents + " Cents");
            nextMoneyTest.IncrementMoney(amountToChange);

            Console.WriteLine();
            Console.WriteLine("\tIncrement Test: ");
            Console.WriteLine("\nAmount to Add: " + amountToChange.ToString("f2") +
                              "\n\tNew Amount: " + nextMoneyTest);
            Console.WriteLine("Press any key to see the next test......");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("\n\nThird Test - input dollars and cents as separate values:");
            Money thirdTest = new Money(AskForInput("Dollars"), AskForInput("Cents as a whole number"));
            Console.WriteLine("\nFull Dollar Amount: " + "\nAmount: " + thirdTest);

            Console.WriteLine("Press any key to see the next test......");
            Console.ReadKey();

            Console.Clear();
            amountToChange = AskForFullDollarAmount();
            Money nextTest = new Money(amountToChange);
            Console.WriteLine(nextTest.ReturnChange());

            Console.WriteLine("Press any key to see the next test......");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("\n\nLast Test - Enter the monetary amount as a single value (with a decimal):");

            Money lastTest = new Money(AskForFullDollarAmount());
            Console.WriteLine("Dollars: " + lastTest.Dollars.ToString("f2") +
                              "\nCents: " + "." + lastTest.Cents +
                              "\nAmount: " + lastTest.ToString());

          
            Console.ReadKey();
        }

        public static int AskForInput(string whichOne)
        {
            string inValue;
            Console.Write("Enter {0}: ", whichOne);
            inValue = Console.ReadLine();
            return (int.Parse(inValue));
        }

        public static decimal AskForFullDollarAmount()
        {
            string inValue;
            Console.Write("Enter the full dollar and cent amount: ");
            inValue = Console.ReadLine();
            return (decimal.Parse(inValue));
        }
    }
}
