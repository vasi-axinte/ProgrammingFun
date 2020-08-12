using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.ListAndDictionary
{
    public class Employee
    {
        public Employee(string lastName, string firstName)
        {
            this.LastName = lastName;
            this.FirstName = firstName;
        }

        public string LastName { get; set; }
        
        public string FirstName { get; set; }
    }
}