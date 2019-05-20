/* OneDimArrayGeneratorApp.cs
 * This application creates and returns a one-dimensional array 
 * containing all the elements in the two-dimensional array. 
 * The values are stored in a row major format. 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDimArrayGeneratorApp
{
    class OneDimArrayGeneratorApp
    {
        static void Main(string[] args)
        {
            int[,] twoDimArray = { {45, 55, 88, 19, 71}, {88, 32, 98, 99, 11},
                                   {23, 78, 16, 67, 42}, {19, 82, 11, 19, 17}, 
                                   {99, 21, 63, 8, 1}, {62, 25, 81, 90, 41}, 
                                   {3, 87, 61, 36, 42}, {2, 51, 6, 12, 33}, 
                                   {91, 93, 36, 88, 28}, {82, 49, 23, 75, 25}, 
                                   {27, 35, 69, 78, 30}, {20, 91, 19, 29, 63} };
            int[] oneDimArray = new int[twoDimArray.Length];

            DisplayTwoDimArray(twoDimArray);
            StoreValues(twoDimArray, oneDimArray);
            DisplayOneDimArray(oneDimArray);
            Console.ReadKey();

        }

        public static void DisplayTwoDimArray(int[,] twoDimArray)
        {
            Console.WriteLine("\t\tOriginal Array");
            for (int row = 0; row < twoDimArray.GetLength(0); row++)
            {
                for (int col = 0; col < twoDimArray.GetLength(1); col++)
                {
                    Console.Write("{0, 8}", twoDimArray[row, col] );
                }
                Console.WriteLine();
            }
        }

        public static void StoreValues(int[,] twoDimArray, int[] oneDimArray)
        {
            int i = 0;
            for (int row = 0; row < twoDimArray.GetLength(0); row++)
            {
                for (int col = 0; col < twoDimArray.GetLength(1); col++)
                {
                    oneDimArray[i] = twoDimArray[row, col];
                    i++;
                }
            }
        }

        public static void DisplayOneDimArray(int[] oneDimArray)
        {
            Console.WriteLine("\n\nNew Array");
            for (int i = 0; i < oneDimArray.Length; i++)
            {
                Console.WriteLine("{0,6}", oneDimArray[i]);
            }
        }
    }

}

