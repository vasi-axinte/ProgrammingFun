using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.OOPPrinciples.Abstraction
{
    /// <summary>
    /// Data abstraction is the process of hiding ceratin details and showing only
    /// esential information to the user.
    /// Abstraction can be achieved with abstract classes or interfaces.
    /// We use abstraction when we want to have a Class that only defines a generalized
    /// form that will be shared to other classes.
    /// In this program, we are using abstract classes
    /// </summary>
    public class AbstractionTheory
    {
        public void Execute()
        {
            Calculator myCalculator = new Calculator();
            myCalculator.Multiplicate(4, 5);
            myCalculator.Square(5);
            Console.ReadLine();
        }
    }
}
