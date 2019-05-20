/* MotorwayApp.cs
 * This application test the Motorway class
 * by instantiating objects of the class.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorwayApp
{
    public class MotorwayApp
    {
        static void Main(string[] args)
        {
            Motorway firstTest = new Motorway("Ramoth", "Drive", 'E', false, "State");
            firstTest.NumberOfLanes = 4;
            firstTest.Surface = "Blacktop";
            Console.WriteLine("First Test\n" + firstTest);

            Motorway secondTest = new Motorway();
            secondTest.NameOfMotorway = "Fenelon";
            secondTest.TypeOfMotorway = "Street";
            secondTest.WhoMaintains = "County";
            secondTest.Direction = ' ';
            secondTest.Toll = true;
            secondTest.Surface = "Gravel";
            Console.WriteLine("\n\nSecond Test\n" + secondTest);

            Motorway thirdTest = new Motorway("Oak", "Blvd", 'E', false, "County");
            Console.WriteLine("\n\nThird Test\n");
            Console.WriteLine("Motorway: " + thirdTest.NameOfMotorway + " " +
                                thirdTest.TypeOfMotorway + " " + thirdTest.Direction +
                                "\nToll: " + thirdTest.Toll +
                                "\nWho Maintains? " + thirdTest.WhoMaintains);

            Console.ReadKey();
        }
    }
}
