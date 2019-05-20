/*StudentApp.cs  
 * This program includes two classes. 
 * This class tests the Student class by 
 * instantiating objects of the class and 
 * testing its properties and mehtods.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    class StudentApp
    {
        static void Main(string[] args)
        {
            
            Student oneStudent = new Student("0001234567", "Joan", "Logan", 3.6,
                                             "Senior", "English");
            Console.WriteLine("\tFirst Test");
            Console.WriteLine(oneStudent);

            Student anotherStudent = new Student(  "0001222876" ,"Chin", "Chang", 3.7 , "Programer","CS");
           

            Console.WriteLine("\n\n\tAnother Test");
            Console.WriteLine(anotherStudent);

            Console.ReadKey();

        }
      
    }
}
