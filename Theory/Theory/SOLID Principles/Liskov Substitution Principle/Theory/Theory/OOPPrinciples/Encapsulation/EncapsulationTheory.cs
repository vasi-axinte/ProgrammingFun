using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.OOPPrinciples.Encapsulation
{
    /// <summary>
    /// Encapsulation is the procedure of encapsulating data and functions into a single class
    /// We use encapsulation to protect our data from accidental corruption
    /// Encapsulation is implemented by using access specifiers. An access specifier defines
    /// the scope and visibility of a class member.
    /// C# supports the following acces specifiers: public/private/protected/internal/protected internal
    /// </summary>
    public class EncapsulationTheory
    {
        public void Execute()
        {
            Employee newEmployee = new Employee();
            newEmployee.DisplayWhatEmployeeKnows();
            newEmployee.DisplayWhatOnlyEmployeeKnows();

            CompanyCEO newCompanyCEO = new CompanyCEO();
            newCompanyCEO.DisplayWhatCompanyKnows();

            Stranger stranger = new Stranger();
            stranger.DisplayWhatEveryoneKnows();

            Console.ReadLine();
        }
    }
}
