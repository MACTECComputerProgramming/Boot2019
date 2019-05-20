/* Employee.cs
 * Data members are employee number, name, 
 * date of hire, and monthly salary. 
 * Properties are defined for each data
 * member. The ToSring( ) method of the
 * object class is overridden.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    public class Employee
    {
        private string employeeNumber;
        private string jobDescription;
        private string department;
        private string employeeFirstName;
        private string employeeLastName;
        private string dateOfHire;
        private double salary;

        public Employee()
        {
        }

        public Employee(string empNo)
        {
            employeeNumber = empNo;
        }

        public Employee(string empNo, double pay)
        {
            employeeNumber = empNo;
            salary = pay;
        }

        // Two string parameters constructor....design decision had to be made regarding which two strings
        public Employee(string empNo, string dateEmployed)
        {
            employeeNumber = empNo;
            dateOfHire = dateEmployed;
        }

        public Employee(string empFirstName, string empLastName, string hireDate)
        {
            employeeFirstName = empFirstName;
            employeeLastName = empLastName;
            dateOfHire = hireDate;
        }

        public Employee(string empNo, string empFirstName, string empLastName, string hireDate)
        {
            employeeNumber = empNo;
            employeeFirstName = empFirstName;
            employeeLastName = empLastName;
            dateOfHire = hireDate;
        }

        public Employee(string empNo, string empFirstName, string empLastName, string job, string dept)
        {
            employeeNumber = empNo;
            employeeFirstName = empFirstName;
            employeeLastName = empLastName;
            jobDescription = job;
            department = dept;
        }

        public Employee(string empNo, string empFirstName, string empLastName, string hireDate, string dept, string job)
        {
            employeeNumber = empNo;
            employeeFirstName = empFirstName;
            employeeLastName = empLastName;
            dateOfHire = hireDate;
            department = dept;
            jobDescription = job;
        }

        public Employee(string empNo, string empFirstName, string empLastName, string hireDate, double newSalary)
        {
            employeeNumber = empNo;
            employeeFirstName = empFirstName;
            employeeLastName = empLastName;
            dateOfHire = hireDate;
            salary = newSalary;
        }

        public Employee(string empNo, string empFirstName, string empLastName, string hireDate, double newSalary, string dept, string job)
        {
            employeeNumber = empNo;
            employeeFirstName = empFirstName;
            employeeLastName = empLastName;
            dateOfHire = hireDate;
            salary = newSalary;
            department = dept;
            jobDescription = job;
        }


        public string EmployeeNumber
        {
            get
            {
                return employeeNumber;
            }
            set
            {
                employeeNumber = value;
            }
        }

        public string EmployeeFirstName
        {
            get
            {
                return employeeFirstName;
            }
            set
            {
                employeeFirstName = value;
            }
        }

        public string EmployeeLastName
        {
            get
            {
                return employeeLastName;
            }
            set
            {
                employeeLastName = value;
            }
        }


        public string DateOfHire
        {
            get
            {
                return dateOfHire;
            }
            set
            {
                dateOfHire = value;
            }
        }

        public double Salary
        {
            get
            {
                return salary;

            }
            set
            {
                salary = value;
            }
        }

        public string JobDescription
        {
            get
            {
                return jobDescription;
            }
            set
            {
                jobDescription = value;
            }
        }

        public string Department
        {
            get
            {
                return department;
            }
            set
            {
                department = value;
            }
        }


        public string ReturnFullName()
        {
            return employeeFirstName + " " + employeeLastName;
        }

        public string ReturnFullNameForSortingPurposes()
        {
            return employeeLastName + ", " + employeeFirstName;

        }

        public override string ToString()
        {
            return "Employee Name: " +
                    ReturnFullName( ) + 
                    "\nEmployee Number: " +
                    employeeNumber +
                    "\nDate of Hire: " +
                    dateOfHire +
                    "\nJob Description: " +
                    jobDescription +
                    "\nDepartment: " +
                    department +
                    "\nSalary: " +
                    salary.ToString("C");
        }
    }
}
