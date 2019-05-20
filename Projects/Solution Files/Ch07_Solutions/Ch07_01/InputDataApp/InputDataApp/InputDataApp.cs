/* InputDataApp.cs
 * This programs gets any number
 * between 0 and 10 from the user 
 * and stores it in an array. Also 
 * counts the number of times a certain value 
 * has been inputted.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputDataApp
{
    class InputDataApp
    {
        static void Main(string[] args)
        {
            int[] entries = new int[11];
            int cntOfInvalidEntries = 0;

            DisplayInstructions();
            PrimeArray(entries);
            cntOfInvalidEntries = GetValues(entries);
            DisplayResults(entries, cntOfInvalidEntries);
            Console.ReadKey();
        }

        public static void PrimeArray(int[] entries)
        {
            //initialize array with 0
            for (int i = 0; i < 11; i++)
            {
                entries[i] = 0;
            }
        }

        public static int GetValues(int [ ] entries)
        {
            int inValue;
            string stringInput; 
            bool moreInput = true;
            int cntOfInvalidEntries = 0;

            Console.Clear();
            while (moreInput)
            {
                Console.Write("\nInput any number between 0 and 10 (-1 to stop): ");
                stringInput = Console.ReadLine();
                
                // Tests to to make sure an integer is entered
                while (int.TryParse(stringInput, out inValue) == false)
                {
                    Console.Write("\nInvalid data type -" +
                            " value must be numeric between 0 and 10 (-1 to stop): ");
                    stringInput = Console.ReadLine();
                    cntOfInvalidEntries++;
                }

                if (inValue == -1)
                    moreInput = false;
                else
                    if (inValue < -1 || inValue > 10)
                    {
                        Console.Write("Invalid number - must be between 0 and 10 -  (-1 to stop): ");
                        cntOfInvalidEntries++;
                    }
                    else
                        entries[inValue]++; // Uses array as an accumulator - adds one at the input value's location
            }
            return cntOfInvalidEntries;
        }

        public static void DisplayInstructions()
        {
            Console.WriteLine("This application will allow you to enter any\n" +
                    "number of entries between 0 and 10.\n\n" +
                    "When you stop entering values, a message will\n" +
                    "display the values you entered along with the\n" +
                    "number of times it was entered.");
            Console.WriteLine("\n\nTo stop entering values type -1\n");
            Console.WriteLine("\n\n\n\nPress any key when you are ready to begin...");
            Console.ReadKey( );
        }

        public static void DisplayResults(int[] entries, int cntOfInvalidEntries)
        {
            int cntOfValidEntries = 0;
            Console.Clear( );
            Console.WriteLine("\tInput Data App\n");
            for (int x = 0; x < 11; x++)
            {
                if (entries[x] != 0)
                {
                    cntOfValidEntries  += entries[x];
                    if (entries[x] == 1)
                        Console.WriteLine("{0} was entered {1} time", x, entries[x]);
                    else
                        Console.WriteLine("{0} was entered {1} times", x, entries[x]);
                }
            }
            Console.WriteLine("\n\nTotal Number of Inputs: {0}", (cntOfInvalidEntries + cntOfValidEntries));
            Console.WriteLine("Number of Invalid Entries: {0}", cntOfInvalidEntries);
            Console.WriteLine("Number of Valid Entries: {0}", cntOfValidEntries);

        }
    }
}
