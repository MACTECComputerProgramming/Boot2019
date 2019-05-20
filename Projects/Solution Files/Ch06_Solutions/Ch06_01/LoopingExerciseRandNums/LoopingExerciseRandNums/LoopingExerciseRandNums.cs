/* LoopingExerciseRandNums.cs
 * This program generates 1000 random numbers.
 * A count is kept of the number of odd values
 * generated. The output is displayed in a 
 * Windows MessageBox.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoopingExerciseRandNums
{
    class LoopingExerciseRandNums
    {
        static void Main(string[] args)
        {
            int numberOfOddValuesGenerated = 0;
            int smallest = 100001;    //Initialized at max possible value
            int largest = -1;        // Initialized at min possible value
            int randomValue;

            Random num1 = new Random();
            for (int i = 0; i < 1000; i++)
            {
                randomValue = GenerateRandonNumber(num1);
                smallest = TestForSmallestValue(randomValue, smallest);
                largest = TestForLargestValue(randomValue, largest);
                IsItAnOddNumber(randomValue, ref numberOfOddValuesGenerated);
            }
            DisplayResults(smallest, largest, numberOfOddValuesGenerated);
        }

        // Note the two argument expression for Next( ) 
        // inclusive first argument; exclusive second argument
        public static int GenerateRandonNumber(Random num1)
        {
            int randomNumber;
            randomNumber = num1.Next(0, 100001);
            return randomNumber;
        }

        public static int TestForSmallestValue(int randomValue, int smallest)
        {
             if (randomValue < smallest)
                 smallest = randomValue;
            return smallest;
        }

        public static int TestForLargestValue(int randomValue, int largest)
        {
             if (randomValue > largest)
                 largest = randomValue;
            return largest;
        }


        public static void IsItAnOddNumber(int randomValue, 
                                            ref int numberOfOddValuesGenerated)
        {
            if (randomValue % 2 == 1)
            {
               numberOfOddValuesGenerated++;
            }
        }

        // Reference added to System.Windows.Forms
        // Output type changed to Windows app from Project....Properties menu option
        static void DisplayResults(int smallest, int largest, int numberOfOddValuesGenerated)
        {
            string result;
            result = "Number of odd values generated:   " + numberOfOddValuesGenerated;
            result += "\nSmallest number: \t" + smallest;
            result += "\nLargest number: \t" + largest;
            MessageBox.Show(result, "Random Number Generation Results",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}