/* ReceiptApp.cs
 * This class tests the Receipt class 
 * by constructing objects, testing properties
 * and methods.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptApp
{
    class ReceiptApp
    {
        static void Main(string[] args)
        {
            Receipt firstReceiptObject = new Receipt();
            firstReceiptObject.ReceiptNumber = AskForStringInput("Receipt Number");
            firstReceiptObject.CustomerNumber = AskForStringInput("Customer Number");
            firstReceiptObject.CustomerName = AskForStringInput("Customer Name");
            firstReceiptObject.CustomerPhone = AskForStringInput("Customer Phone");
            firstReceiptObject.CustomerAddress = AskForStringInput("Customer Address");
            firstReceiptObject.ItemNumber = AskForStringInput("Item Number Purchased");
            firstReceiptObject.ItemDesc = AskForStringInput ("Description of the Part");
            firstReceiptObject.UnitPrice = AskForUnitPrice();
            firstReceiptObject.QtyPurchased = AskForQtyPurchased();
            
            Console.Clear();
            Console.WriteLine("\tFirst Test");
            Console.WriteLine(firstReceiptObject.ToString());
        

            Receipt secondReceiptObject = new Receipt("XYC-2345");
            secondReceiptObject.DateOfPurchase = "09/25/2013";
            secondReceiptObject.CustomerName = "David Zeller";
            secondReceiptObject.CustomerNumber = "001237";
            secondReceiptObject.CustomerAddress = "14 Parks Blvd";
            secondReceiptObject.CustomerPhone = "762-123-4412";
            secondReceiptObject.ItemNumber = "4XZ23-7";
            secondReceiptObject.ItemDesc = "Wiper blade";
            secondReceiptObject.UnitPrice = 9.50;
            secondReceiptObject.QtyPurchased = 2;
     
            Console.WriteLine("\n\n\tSecond Test");
            Console.WriteLine("Receipt Number: " + secondReceiptObject.ReceiptNumber + " - Date: " + secondReceiptObject.DateOfPurchase);
            Console.WriteLine("Description of Part: " + secondReceiptObject.ItemDesc);
            Console.WriteLine("Item Number: " + secondReceiptObject.ItemNumber  + "\nQuantity Purchased: " + secondReceiptObject.QtyPurchased +
                               "\nTotal Cost: {0}", secondReceiptObject.CalculateTotalCost( ).ToString("c")); 

            Receipt thirdReceiptObject = new Receipt("TY-5432", "0004567");
            thirdReceiptObject.CustomerName = "Anna Leigh";
            thirdReceiptObject.UnitPrice = 7.22;
            thirdReceiptObject.QtyPurchased = 3;
            Console.WriteLine("\n\n\tThird Test");
            Console.WriteLine(thirdReceiptObject);

            Receipt lastReceiptObject = new Receipt("XYC-2349", "11/05/2013", "001238", "Elizabeth Smith", 
                                                        "1247 Fenelon Falls Rd", "343-12-9876", "XQ-1267", 
                                                        "Brake Fluid", 14.78, 5);
            Console.WriteLine("\n\n\tLast Test");
            Console.WriteLine("Item Description: " + lastReceiptObject.ItemDesc +
                              "\nItem Number: " + lastReceiptObject.ItemNumber +
                              "\nQty Purchased: " + lastReceiptObject.QtyPurchased +
                              "\nUnit Price: " + lastReceiptObject.UnitPrice.ToString("f2") +
                              "\nTotal Cost: " + lastReceiptObject.CalculateTotalCost().ToString("C"));

            Console.ReadKey();
       }

        public static double AskForUnitPrice()
        {
            string inValue;
            double theUnitPrice;
            Console.Write("Enter Unit Price: ");
            inValue = Console.ReadLine();
            theUnitPrice = double.Parse(inValue);
            return theUnitPrice;
        }

        public static string AskForStringInput(string whatData)
        {
            string inValue;
            Console.Write("Please enter {0}: ", whatData);
            inValue = Console.ReadLine();
            return inValue;
        }

        public static int AskForQtyPurchased( )
        {
            string inValue;
            Console.Write("Enter Quantity Purchased: ");
            inValue = Console.ReadLine();
            return (int.Parse(inValue));
        }
   }
}
