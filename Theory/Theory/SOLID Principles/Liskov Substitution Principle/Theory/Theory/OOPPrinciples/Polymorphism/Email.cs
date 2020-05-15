using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.OOPPrinciples.Polymorphism
{
    public class Email
    {
        /// <summary>
        /// function with 1 string parameter
        /// </summary>
        /// <param name="employee"></param>
        public void SendEmail(string employee)
        {
            Console.WriteLine("Email was send");
        }

        /// <summary>
        /// function with the same name but 2 string parameters
        /// "+" operand combines 2 can combine 2 strings together
        /// </summary>
        public void SendEmail(string CEO, string employee)
        {
            Console.WriteLine("Email was send " + "to {0} and to {1}", CEO, employee);
        }
    }
}
