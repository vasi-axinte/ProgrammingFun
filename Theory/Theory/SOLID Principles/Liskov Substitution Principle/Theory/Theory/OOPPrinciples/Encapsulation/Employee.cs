using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.OOPPrinciples.Encapsulation
{
    public class Employee
    {
        public Employee()
        {
            this.LastName = "axinte";
            this.FirstName = "cristi";
            this.CNP = 0123;
            this.Email = "axinte@gmail.com";
            this.Hobby = "arisoft";
        }

        /// <summary>
        /// Method that will show what our employee knows about himself
        /// </summary>
        public void DisplayWhatEmployeeKnows()
        {
            Console.WriteLine(LastName + " " + FirstName + " " + CNP + " " + Email + " " + Hobby);
        }

        /// <summary>
        /// Method that will show what only our employe knows about himself
        /// </summary>
        public void DisplayWhatOnlyEmployeeKnows()
        {
            Console.WriteLine(Hobby);
        }

        //Any public member can be accessed from outside the class
        public string LastName { get; set; }   

        public string FirstName { get; set; }

        //Protected acces specifier allows a child class to access the member variables and
        //member functions of its base class
        protected int CNP { get; set; }

        protected string Email { get; set; }

        //Only functions of the same class can access private members.
        private string Hobby { get; set; }
    }
}