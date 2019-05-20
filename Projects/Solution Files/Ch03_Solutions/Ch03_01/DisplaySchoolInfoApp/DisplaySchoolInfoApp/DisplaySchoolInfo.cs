/* DisplaySchoolInfo.cs
 * This application displays information
 * about your school. Practice is giving writing
 * and invoking methods.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplaySchoolInfoApp
{
    class DisplaySchoolInfo
    {
        static void Main(string[] args)
        {
            string schoolInfo;

            DisplayAsterisks();
            schoolInfo = RetrieveSchoolInfo();
            Console.WriteLine(schoolInfo);
            DisplayAsterisks();

            Console.ReadKey();
        }

        public static void DisplayAsterisks()
        {
            Console.WriteLine("*************************************");
        }

        public static string RetrieveSchoolInfo()
        {
            string returnValue;
            returnValue = "\tTrent University\n" +
                          " School Colors: Red/Black\n" +
                          " Mascot: Dolphin\n" +
                          " Location: Williamsburg New Jersey\n" +
                          " Number of Students: 27,000";
            return returnValue;
        }
    }
}
