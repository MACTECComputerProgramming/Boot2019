/* EmployeeApp.cs 
 * This application test the Employee class. Users enter employee 
 * name and sales. These values are used to construct an Employee
 * object. This class then tests the properties and other methods
 * of the Employee class.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class EmployeeApp
    {
        static void Main(string[] args)
        {
            string anEmployeeLastName,
                   anEmployeeFirstName;
            decimal salesForWeek;

            Console.Write("You will be asked to enter the name of an employee\n"
                + "and his weekly sales. Calculations will be performed to \n"
                + "determine his deductions and take home pay.\n\n");
            anEmployeeFirstName = GetInfo("an employee\'s first name");
            anEmployeeLastName = GetInfo("an employee\'s last name");

            salesForWeek = decimal.Parse(GetInfo(anEmployeeFirstName + " " + 
                anEmployeeLastName + "\'s weekly sales"));

            Employee firstEmployee = new Employee(anEmployeeFirstName, anEmployeeLastName, salesForWeek);
            DisplayResults(firstEmployee);
            Console.WriteLine("Press any key to see the next test....");
            Console.ReadKey();

            Console.Clear();
            Employee secondEmployee = new Employee("Alma", "Hicjack", 14582.50m);
            Console.WriteLine(secondEmployee);
        }

        static string GetInfo(string info)
        {
            Console.Write("Please enter {0}: ", info);
            return (Console.ReadLine());
        }

        static void DisplayResults(Employee person)
        {
            Console.Clear();
            Console.WriteLine("Weekly information for {0} {1}", person.EmployeeFirstName, person.EmployeeLastName);
            Console.WriteLine("{0,-20} {1,12:C}", "Sales: ", person.WeeklySales);
            Console.WriteLine();
            Console.WriteLine("{0,-25} {1,12:C}", 
                "Gross pay: ", person.CalculateGrossPay());
            Console.WriteLine("{0,-25} {1,12:C}", 
                "Federal tax paid: ", person.CalculateFedTaxPaid());
            Console.WriteLine("{0,-25} {1,12:C}",
                "Social security paid: ", person.CalculateSocSecPaid());
            Console.WriteLine("{0,-25} {1,12:C}",
                "Retirement contribution: ", person.CalculateRetirementPaid());
            Console.WriteLine("{0,-25} {1,12:C}",
                "Total deductions: ", person.CalculateTotalDeductions());
            Console.WriteLine();
            Console.WriteLine("{0,-25} {1,12:C}",
                "Take home pay: ", person.CalculateTakeHomePay());
        }
    }
}
