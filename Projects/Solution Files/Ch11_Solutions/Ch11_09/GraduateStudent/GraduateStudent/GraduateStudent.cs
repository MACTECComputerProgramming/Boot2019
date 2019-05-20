using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentNamespace;

namespace GraduateStudentNamespace
{
    public class GraduateStudent : Student
    {
        private string degreeType;
		private string almaMater; 

		public GraduateStudent()
            : base( )
		{
		}

		public GraduateStudent(string first, string last, string currentMajor, string id, 
							string currentDegree, string schoolWhereDegreeEarned)
            : base(first, last, currentMajor, id)
		{
            degreeType = currentDegree;
            almaMater = schoolWhereDegreeEarned;
		}

		public string DegreeType
		{
			get
			{
				return degreeType;
			}
			set
			{
				degreeType = value;
			}
		}

		public string AlmaMater
		{
			get
			{
				return almaMater;
			}
			set
			{
				almaMater = value;
			}
		}

        public override string ToString()
        {
            return base.ToString() +
                "\nUndergraduate Degree: " + degreeType;
        }
	}
}
