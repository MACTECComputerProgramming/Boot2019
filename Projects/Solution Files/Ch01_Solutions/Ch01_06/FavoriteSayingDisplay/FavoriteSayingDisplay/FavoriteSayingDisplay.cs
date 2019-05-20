/* FavoriteSayingDisplay
 * This application displays a favorite saying three ways
 * giving practice using Write( ) method. With the third
 * printing, practice is given making a choice regarding 
 * invoking the WriteLine( ) versus Write( ) method.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoriteSayingDisplay
{
    class FavoriteSayingDisplay
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Output #1");
            Console.Write("Laugh often, ");
            Console.Write("Dream big, ");
            Console.Write("Reach for the stars!");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Output #2");
            Console.Write("Laugh often,  \n");
            Console.Write("Dream big, \n");
            Console.Write("Reach for the stars!");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Output #3");
            Console.WriteLine("\tLaugh");
            Console.WriteLine("\toften,");
            Console.WriteLine("\tDream ");
            Console.WriteLine("\tbig,");
            Console.WriteLine("\tReach");
            Console.WriteLine("\tfor");
            Console.WriteLine("\tthe");
            Console.WriteLine("\tstars!");

            Console.ReadKey();
        }

    }
}
