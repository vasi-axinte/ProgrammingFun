using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.OOPPrinciples.Encapsulation
{
    public class Stranger
{ 
        
        Employee newEmployee = new Employee();
        /// <summary>
        /// Method that will display what everyone knows about our employee
        /// </summary>
        public void DisplayWhatEveryoneKnows()
        {
            Console.WriteLine(newEmployee.LastName + " " + newEmployee.FirstName);
        }
    }
}
