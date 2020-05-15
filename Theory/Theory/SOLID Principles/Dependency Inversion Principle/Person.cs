using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.SOLID_Principles.Dependency_Inversion_Principle
{
    public class Person : IPerson
    {
        public Person(string firstName, string lastName, string email, string address)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Address = address;
        }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }
    }
}
