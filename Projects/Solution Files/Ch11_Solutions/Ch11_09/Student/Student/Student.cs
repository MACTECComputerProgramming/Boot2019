/* Student.cs   
 * This is an abstract base class
 * that include common characteristics
 * found with all students such as name,
 * student id and major (which could be
 * undecided or undeclared).
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentNamespace
{
    public abstract class Student
    {
        private string fName;
        private string lName;
        private string currentMajor;
		private string id;

		public Student()
		{
		}

        public Student(string fn, string ln, string major, string idNum)
        {
            fName = fn;
            lName = ln;
            currentMajor = major;
            id = idNum;
        } 
        public Student(string fn, string ln, string idNum)
        {
            fName = fn;
            lName = ln;
            id = idNum;
        } 

		public Student(string fn, string ln)
		{
            fName = fn;
            lName = ln;
		} 
        
        public string FirstName
        {
            get 
            {
                return fName;
            }
            set
            {
                fName = value;
            }
        }
        public string LastName
        {
            get 
            {
                return lName;
            }
            set
            {
                lName = value;
            }
        }
		public string Major
		{
			get
			{
				return currentMajor;
			}
			set
			{
				currentMajor = value;
			}
		}

		public string Id
		{
			get
			{
				return id;
			}
			set
			{
				id = value;
			}
		}

        public override string ToString()
        {
            return "Name: " + fName + " " + lName +
                "\nMajor: " + currentMajor;
        }
	}
}
