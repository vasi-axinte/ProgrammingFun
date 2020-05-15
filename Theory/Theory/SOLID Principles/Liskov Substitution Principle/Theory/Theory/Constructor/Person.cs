using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.Constructor
{
    public class Person
    {
        /// <summary>
        /// This is an instance default constructor
        /// </summary>
        public Person()
        {
            this.LastName = "Axinte";
            this.FirstName = "Cristi";
            this.Age = 20;
        }
        /// <summary>
        /// This is an instance parameterized constructor
        /// </summary>
        public Person(string lastName, string firstName, int age)
        {
            this.LastName = lastName;
            this.FirstName = firstName;
            this.Age = age;
        }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public int Age { get; set; }

    }
}
