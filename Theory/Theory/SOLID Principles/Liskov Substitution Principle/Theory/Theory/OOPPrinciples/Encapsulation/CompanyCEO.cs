using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.OOPPrinciples.Encapsulation
{
    /// <summary>
    /// CompanyCEO class inherits Employee class.
    /// Like this, CompanyCEO class will have access to Employee class protected and 
    /// public access spcifiers
    /// </summary>
    public class CompanyCEO : Employee
    {
        /// <summary>
        /// Method that will display what company knows about his employee
        /// </summary>
        public void DisplayWhatCompanyKnows()
        {
            Console.WriteLine(LastName + " " + FirstName + " " +Email + " " + CNP);
        }          
    }
}
