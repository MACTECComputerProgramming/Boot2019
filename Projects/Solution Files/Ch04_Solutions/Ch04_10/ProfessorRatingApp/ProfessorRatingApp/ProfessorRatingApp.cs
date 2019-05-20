/* ProfessorRatingApp.cs
 * This class instantiates objects of the
 * ProfessorRating class. It tests the different
 * constructors, properties and methods of that class.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessorRatingApp
{
    class ProfessorRatingApp
    {
        static void Main(string[] args)
        {
            int score1,
                score2,
                score3;
            string  professorID,
                    firstName,
                    lastName;

            DisplayInstructions();

            professorID = GetInfo("Professor Number");
            firstName = GetInfo("Professor\'s First Name");
            lastName = GetInfo("Professor\'s Last Name");
            Console.WriteLine();
            score1 = int.Parse(GetInfo("Easiness Rating"));
            score2 = int.Parse(GetInfo("Helpfulness Rating"));
            score3 = int.Parse(GetInfo("Clarity Rating"));
            ProfessorRating firstStudent = new ProfessorRating(professorID, firstName, lastName, score1, score2, score3);
            DisplayResults(firstStudent);

            Console.WriteLine("\nPress any key to see the next test...");
            Console.ReadKey();
            Console.Clear();
            
            ProfessorRating secondProf = new ProfessorRating();
            secondProf.ProfessorNumber = GetInfo("Professor Number");
            secondProf.ProfessorFirstName = "Natalia";
            secondProf.ProfessorLastName = "Gonzalas";
            secondProf.FirstScore = int.Parse(GetInfo("Easiness Rating (1-5)"));
            secondProf.SecondScore = int.Parse(GetInfo("Helpfulness Rating (1-5)"));
            secondProf.ThirdScore = int.Parse(GetInfo("Clarity Rating (1-5)"));
            Console.Clear();
            Console.WriteLine(secondProf);

            Console.WriteLine("\nPress any key to see the next test...");
            Console.ReadKey();
            Console.Clear();

            ProfessorRating anotherProf = new ProfessorRating("UC-1143", "Morris", "Dennis", 3, 5, 4);
            Console.WriteLine(anotherProf);
            Console.ReadKey();
            


        }

        public static void DisplayInstructions()
        {
            Console.WriteLine("You will be asked to enter a profesor ID number and three ratings." +
                    "\nThe ratings relates to easiness, helpfulness, and clarity - in that order." +
                    "\nThe information, including average rating will be displayed.\n\n" +
                    "Ratings are based on a 1 - 5 scale with 1 being the lowest and 5 the highest");
            Console.WriteLine("\n\nPress any key when you are ready to begin...");

            Console.ReadKey();
            Console.Clear();
        }

        public static string GetInfo(string info)
        {
            string inputValue;

            Console.Write("Please enter the {0}: ", info);
            inputValue = Console.ReadLine();
            return inputValue;
        }

        public static void DisplayResults(ProfessorRating person)
        {
            Console.Clear();
            Console.WriteLine("\nProfessor Number: {0} ", person.ProfessorNumber);
            Console.WriteLine("Professor Name: {0} {1}", person.ProfessorFirstName, person.ProfessorLastName); 
            Console.WriteLine("\nEasiness: {0}", person.FirstScore);
            Console.WriteLine("Helpfulness: {0}", person.SecondScore);
            Console.WriteLine("Clarity: {0}", person.ThirdScore);
            Console.WriteLine("\nAverage Rating: {0}\n\n",
                person.CalculateAverageRating().ToString("F2"));
        }
    }
}
