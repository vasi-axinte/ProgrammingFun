using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.DRY_Principle
{
    public class Student
    {

        /// <summary>
        /// Creating a constructor with only 2 paramters
        /// </summary>
        public Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
       public string FirstName { get; set; }

       public string LastName { get; set; }

       /// <summary>
       /// Because we know that our students have the same specialization and university
       /// we can give to the proprietes those values.
       /// </summary>
       public readonly string Univeristy = "UBB";

       public readonly string Specialization = "Computer Science";

        /// <summary>
        /// This method will display on screen all details about our Student
        /// </summary>
        public void WriteAllStudentDetails(string firstName, string lastName)
        {
            Console.WriteLine(firstName + " " + lastName + " " + Univeristy + " " + Specialization);
        }
    }
}
