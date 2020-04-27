using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.OOPPrinciples
{
    public abstract class Operations
    {
        /// <summary>
        /// Abstract methods can only be used in an abstract class, and it does not have a body
        /// The body is provided by the derived class
        /// You are not allowed to declare the abstract methods outside the abstract class
        /// </summary>
        public abstract void Multiplicate(int number1, int number2);

        public abstract void Square(int number);
    }

   
}
