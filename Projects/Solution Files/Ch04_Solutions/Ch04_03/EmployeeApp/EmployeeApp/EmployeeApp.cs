/* EmployeeApp.cs
 * This class tests the Employee class,
 * calling constructor methods to instantiate
 * objects, using properties to set values and
 * displaying object's data through invoking the
 * ToString( ) method. 
 */using System;

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
            Employee firstEmployeeObject = new Employee();
            firstEmployeeObject.EmployeeFirstName = AskForEmployeeName("First");
            firstEmployeeObject.EmployeeLastName = AskForEmployeeName("Last");
            firstEmployeeObject.EmployeeNumber = AskForEmployeeNumber();
            firstEmployeeObject.DateOfHire =
                AskForDateOfHire(firstEmployeeObject.ReturnFullName( ));
            firstEmployeeObject.Salary = AskForSalary();
            firstEmployeeObject.JobDescription = AskForJobDescription();
            firstEmployeeObject.Department = AskForDepartment();
            
            Console.Clear();
            Console.WriteLine("\tFirst Test");
            Console.WriteLine(firstEmployeeObject.ToString());

            Employee secondEmployeeObject = new Employee("C-2345");
            secondEmployeeObject.Salary = 95000;
            
            Console.WriteLine("\n\n\tSecond Test");
            Console.WriteLine("Employee Number: " + secondEmployeeObject.EmployeeNumber +
                               "\nSalary: {0:c}", secondEmployeeObject.Salary);
            
            
            Employee thirdEmployeeObject = new Employee("C-2234", "Timothy Walnut", "01/01/2009");
            thirdEmployeeObject.Salary = 75000;
            thirdEmployeeObject.Department = "Information Technology";
            thirdEmployeeObject.JobDescription = "C# Programmer Analyst";
            Console.WriteLine("\n\n\tThird Test");
            Console.WriteLine(thirdEmployeeObject);

            Employee lastEmployeeObject = new Employee("A-2334", "Maria", "Smith", "01/01/2008", 60000);
            
            Console.WriteLine("\n\n\tAnother Test");
            Console.WriteLine("Employee Name: " + lastEmployeeObject.EmployeeFirstName + " " + lastEmployeeObject.EmployeeLastName  +
                              "\nEmployee Number: " + lastEmployeeObject.EmployeeNumber +
                              "\nDateOfHire: " + lastEmployeeObject.DateOfHire +
                              "\nSalary: " + lastEmployeeObject.Salary.ToString("C"));
            
            Console.ReadKey();
        }

        public static double AskForSalary()
        {
            string inValue;
            double theSalary;
            Console.Write("Enter salary amount: ");
            inValue = Console.ReadLine();
            theSalary = double.Parse(inValue);
            return theSalary;
        }

        public static string AskForEmployeeName(string whichPartOfName)
        {
            string inValue;
            Console.Write("Enter Employee {0} Name: ", whichPartOfName);
            inValue = Console.ReadLine();
            return inValue;
        }
        public static string AskForDateOfHire(string name)
        {
            string inValue;
            Console.Write("When was {0} Hired? ", name);
            inValue = Console.ReadLine();
            return inValue;
        }
        public static string AskForEmployeeNumber()
        {
            string inValue;
            Console.Write("Enter Employee Number: ");
            inValue = Console.ReadLine();
            return(inValue);
        }

        public static string AskForDepartment()
        {
            string inValue;
            Console.Write("Enter Employee Department: ");
            inValue = Console.ReadLine();
            return (inValue);
        }

        public static string AskForJobDescription()
        {
            string inValue;
            Console.Write("Enter Job Description: ");
            inValue = Console.ReadLine();
            return (inValue);
        }


    }
}
