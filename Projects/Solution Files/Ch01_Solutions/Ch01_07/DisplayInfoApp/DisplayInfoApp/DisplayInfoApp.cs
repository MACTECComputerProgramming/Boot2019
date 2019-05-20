/* DisplayInfoApp.cs
 * This application produces a listing with
 * information such as your name, hometown, major, 
 * hobby and/or favorite activity. The listing is
 * placed on a single line with each entry 
 * separated by backslashes.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayInfoApp
{
    class DisplayInfoApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********************************************");
            Console.WriteLine("*|\tName: Barbara Doyle\\                *");
            Console.WriteLine("*\tHometown: Jacksonville\\             *");
            Console.WriteLine("*\tMajor: CS\\                          *");
            Console.WriteLine("*\tHobby: Biking\\                      *");
            Console.WriteLine("*\tFavorite Activity: Swimming\\       |*");
            Console.WriteLine("*********************************************");
            Console.ReadKey();
        }
    }
}
