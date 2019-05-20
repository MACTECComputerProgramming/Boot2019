using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    class Student
    {
        public string studentNum { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public double gpa { get; set; }

        public string classification { get; set; }

        public string major { get; set; }
        

        // Default constructor
        public Student()
        {
        }

        // Constructor used to create Student object
        public Student(string num, string first, string last, double ave,
                       string year, string focus)
        {
            studentNum = num; 
            firstName = first;
            lastName = last;
            gpa = ave;
            classification = year;
            major = focus;
        }

       
       


        public override string ToString()
        {
            return "Student Number: " + studentNum +
                "\nName: " + firstName + " " + lastName +
                "\nGPA: " + gpa + "\nClassification: " + classification +
                "\nMajor: " + major;

        }
    }
}
