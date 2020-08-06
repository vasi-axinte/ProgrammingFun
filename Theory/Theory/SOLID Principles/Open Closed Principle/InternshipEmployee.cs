using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.SOLIDPrinciples.OpenClosedPrinciple
{
    /// <summary>
    /// Class InternshipEmplyee inherits base class Emplyee, like this when add our new
    /// functionality that calculates the salary of the employee, we won`t modify the
    /// base class, and we are respecting the Open Closed Principle
    /// </summary>
    public class InternshipEmployee : Employee
    {

        /// <summary>
        /// We are creating the constructor for InternshipEmployee and we are assigning
        /// the lastName value using the base class
        /// </summary>
        public InternshipEmployee(string lastName) : base(lastName)
        {
        }
      
        /// <summary>
        /// Creating a new method that calculates the salary of the employee
        /// </summary>
        public override void CalculateSalary()
        {
            Console.WriteLine("{0}, Your salary is:" + 1200, LastName);
        }
    }
}
