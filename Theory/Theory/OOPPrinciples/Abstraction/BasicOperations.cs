using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.OOPPrinciples.Abstraction
{
    /// <summary>
    /// We cannot acces the abstract class directly with the new operator. 
    /// To acces the abstract class we have to use inheritance
    /// /// In our case, class Calculator inherits abstract class Operations
    /// </summary>
    public class BasicOperations : Operations
    {
        /// <summary>
        /// Overriding the abstract method Multiplication, using the override keyword 
        /// </summary>
        public override void Multiplicate(int number1, int number2)
        {
            Console.WriteLine(number1 * number2);
        }

        /// <summary>
        /// Overriding the abstract method Square, using the override keyword 
        /// </summary>
        public override void Square(int number1)
        {
            Console.WriteLine(number1 * number1);
        }
    }
}

