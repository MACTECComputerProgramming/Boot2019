/* UnderGraduateStudent.cs   
 * This class extends StudentBase.cs
 * to include common characteristics
 * of undergraduate students such
 * as guardian name and address and
 * current classification (i.e. freshman,
 * sophomore, etc.).
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentNamespace;

namespace UndergraduateStudentNamespace
{
    public class UndergraduateStudent : Student
    {
   
        private string classification;
		private string guardianName;
		private string guardianAddress;

		public UndergraduateStudent()
            : base( )
		{
		}

		public UndergraduateStudent(string firstName, string lastName, string major, 
                                    string id, string yearInSchool, 
								    string nameOfGuardian, string homeAddress)
            : base(firstName, lastName, major, id)
		{
            classification = yearInSchool;
            guardianName = nameOfGuardian;
            guardianAddress = homeAddress;
		}
       
        public UndergraduateStudent(string firstName, string lastName, string major,
                            string id, string yearInSchool)
            : base(firstName, lastName, major, id)
        {
            classification = yearInSchool;
        }



		public string Classification
		{
			get
			{
				return classification;
			}
			set
			{
				classification = value;
			}
		}

		public string GuardianName
		{
			get
			{
				return guardianName;
			}
			set
			{
				guardianName = value;
			}
		}

		public string GuardianAddress
		{
			get
			{
				return guardianAddress;
			}
			set
			{
				guardianAddress = value;
			}
		}
        public override string ToString()

        {
 	        return base.ToString() +
                "\nClassification: " + classification;
        }
	}
}