/* This class includes data members for
 * employee name and sales. A number
 * of constants are defined that are used
 * with each object, including commission rate,
 * fed. tax rate, soc security rate, and 
 * retirement contribution. Instance
 * methods are defined to calculated these
 * value
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Employee
    {
        private const decimal COMMISSION_RATE = 0.07m;
        private const decimal FEDERAL_TAX_RATE = 0.18m;
        private const decimal SOCIAL_SECURITY_RATE = 0.06m;
        private const decimal RETIREMENT_CONTRIBUTION = 0.10m;

        private string employeeLastName;
        private string employeeFirstName;
        private decimal weeklySales;

        public Employee(string first, string last, decimal sales)
        {
            employeeFirstName = first;
            employeeLastName = last;
            weeklySales = sales;
        }

        public Employee(decimal sales)
        {
            weeklySales = sales;
        }

        public Employee(string last, string first)
        {
            employeeLastName = last;
            employeeFirstName = first;
        }
        public Employee()
        {
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

        public decimal WeeklySales
        {
            get
            {
                return weeklySales;
            }
            set
            {
                weeklySales = value;
            }
        }

        public decimal CalculateGrossPay()
        {
            return weeklySales * COMMISSION_RATE;
        }

        public decimal CalculateFedTaxPaid()
        {
            return CalculateGrossPay() * FEDERAL_TAX_RATE;
        }

        public decimal CalculateSocSecPaid()
        {
            return CalculateGrossPay() * SOCIAL_SECURITY_RATE;
        }

        public decimal CalculateRetirementPaid()
        {
            return CalculateGrossPay() * RETIREMENT_CONTRIBUTION;
        }

        public decimal CalculateTotalDeductions()
        {
            return CalculateFedTaxPaid() + CalculateSocSecPaid() + CalculateRetirementPaid();
        }

        public decimal CalculateTakeHomePay()
        {
            return CalculateGrossPay() - CalculateTotalDeductions();
        }

        public override string ToString()
        {
            return "Name: " + employeeFirstName + " " + employeeLastName +
                "\nSales: " + weeklySales.ToString("C") +
                "\nGross Pay: " + CalculateGrossPay().ToString("C") +
                "\nFed. Taxes: " + CalculateFedTaxPaid().ToString("C") +
                "\nSoc. Sec.: " + CalculateSocSecPaid().ToString("C") +
                "\nRetirement: " + CalculateRetirementPaid().ToString("C") +
                "\n\nTotal Deductions: " + CalculateTotalDeductions().ToString("C") +
                "\nTake home pay: " + CalculateTakeHomePay().ToString("C");
        }
    }
}
