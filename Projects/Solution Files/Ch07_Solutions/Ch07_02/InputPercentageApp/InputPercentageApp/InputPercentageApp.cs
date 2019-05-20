/*InputPercentageApp.cs
 * This application accepts any number 
 * monthly sales figures.It totals the values and
 * displays a report showing the original value input 
 * and the percentage it contributes to the total.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputPercentageApp
{
    class InputPercentageApp
    {
        static void Main(string[] args)
        {
            double sum = 0;
            int arraySize;
           
            DisplayInformationAboutApp();
            arraySize = PromptForArraySize();
            double[] inputValues = new double[arraySize];

            GetTheData(inputValues);
            sum = CalculateSum(inputValues);
            DisplayResults(inputValues, sum); 
            Console.ReadKey();
        }



        public static void DisplayInformationAboutApp()
        {
            Console.WriteLine("\t Sales Percentage App" +
                "\n\n***  You will be prompted to enter  monthly sales figures.   ***" +
                "\n***  The values entered will be displayed, along with the    ***" +
                "\n***  percentage of the total contributed by that value.      ***");
            Console.WriteLine("\n\n\nPress any key when you are ready to begin...");
            Console.ReadKey();
            Console.Clear();
        }

        public static int PromptForArraySize()
        {
            string input;
            int size;

            Console.Write("\nEnter how many months of data would you like to input:  ");
            input = Console.ReadLine();
            while (int.TryParse(input, out size) == false)
            {
                Console.WriteLine("Invalid data");
                Console.Write("The count must be numeric -  please re-enter the number: ");
                input = Console.ReadLine();
            }
            return (size);
        }

        public static void GetTheData(double[] inputValues)
        {
            double numInput;

            Console.Clear();
            for (int i = 0; i < inputValues.Length; i++)
            {
                numInput = PromptForNums(i + 1);
                inputValues[i] = numInput;
            }
        }

        public static double PromptForNums(int j)
        {
            string input;
            double numInput;

            Console.Write("Please enter sales figure #{0}:  ", j);
            input = Console.ReadLine();
            while (double.TryParse(input, out numInput) == false)
            {
                Console.WriteLine("Invalid data entered");
                Console.Write("Please re-enter the sales figure#{0}:  ", j);
                input = Console.ReadLine();
            }

            return numInput;
        }

        public static double CalculateSum(double [ ] inputValues)
        {
            double sum = 0;
            foreach (double val in inputValues)
                sum += val;
            return sum;
        }

        public static double GetPercentage(double num, double total)
        {
            return (num * 100.0) / total;
        }

        public static void DisplayResults(double[] array, double total)
        {
            Console.Clear();
            if (total > 0)
            {
                Console.WriteLine("\tIon Realty Sales App\n");
                Console.WriteLine("Total Sales: {0:C}\n\n", total);
                Console.WriteLine("{0,9} {1,16}", "Monthly","% Contributed");
                Console.WriteLine("{0,9} {1,16}\n", "Sales", " to Total");
                foreach (int i in array)
                {
                    Console.WriteLine("{0,9:C} {1,12:F1}%",
                        i, GetPercentage(i, total));
                }
            }
            else
                Console.WriteLine("\nNo values were received.\n\n");
        }
    }
}
