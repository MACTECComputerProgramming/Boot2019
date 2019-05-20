/*CurrentDirectory.cs
 * Displays the current directory 
 * and lists the files in that directory.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DirectoryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string result;
            DirectoryInfo info = new DirectoryInfo(".");

            result = info.FullName + "\n\n" +
                "File Names".PadRight(40) + "Size".PadLeft(20) + "\n";
            foreach (FileInfo fil in info.GetFiles("*.*"))
            {
                result += fil.Name.PadRight(40) + fil.Length.ToString().PadLeft(20) + "\n";
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
