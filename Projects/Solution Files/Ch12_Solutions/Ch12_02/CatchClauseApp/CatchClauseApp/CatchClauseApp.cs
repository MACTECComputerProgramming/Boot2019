/* CatchClauseApp.cs
 * This application throws multiple
 * exceptions - one at a time.
 * 
 * After testing #1 try clause, comment it out
 *  and uncommment #2, #3, or #4. Repeat the
 * process to see each exception being thrown. 
 * No need to change the catch clauses.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchClauseApp
{
    class CatchClauseApp
    {
        static void Main(string[] args)
        {
            try
            {
                // #1: IndexOutOfRangeException will be thrown
                double[] weeklyWages = { 3, 4, 5 };

                Console.WriteLine("Values being displayed from array");
                for (int i = 1; i <= 4; i++)
                {
                    Console.WriteLine("\n\t" + weeklyWages[i]);
                }



                //// #2: FormatException will be thrown
                //int calcResult;

                //for (int i = 1; i <= 4; i++)
                //{
                //    Console.Write("\nEnter a number\n" +
                //        "(or letter to throw an exception): ");
                //    calcResult = 3 * int.Parse(Console.ReadLine());
                //    Console.WriteLine(calcResult.ToString());
                //}



                //// #3: DivideByZeroException will be thrown
                //int input;

                //Console.Write("\n\tEnter a number:\t");
                //input = int.Parse(Console.ReadLine());
                //calcResult = (input / (input - input));
                //Console.WriteLine(calcResult.ToString());



                //// #4: Exception will be thrown
                //short shortInput;

                //Console.Write("\n\tEnter a number greater than 32767: ");
                //shortInput = short.Parse(Console.ReadLine());
                //Console.WriteLine(shortInput.ToString());
            }

            // #1
            catch (IndexOutOfRangeException e)
            {
                Console.Error.WriteLine(
                    "\n\nError in loop termination condition.");
                Console.Error.WriteLine(
                    "\nException type:\t" + e.Message + "\n\n\n");
            }

            // #2
            catch (FormatException e)
            {
                Console.Error.WriteLine(
                    "\nError in parameter types.");
                Console.Error.WriteLine(
                    "\nException type:\t" + e.Message + "\n\n\n");
            }

            // #3
            catch (ArithmeticException e)
            {
                Console.Error.WriteLine(
                    "\nArithmeticException thrown.");
                Console.Error.WriteLine(
                    "\nException type:\t" + e.Message + "\n\n\n");
            }

            // #4
            catch (Exception e)
            {
                Console.Error.WriteLine(
                    "\nValue entered exceeds the range of the\n" +
                    "data type designated to store the input.");
                Console.Error.WriteLine(
                    "\nException type:\t" + e.Message + "\n\n\n");
            }
            Console.ReadKey();
        }
    }
}
