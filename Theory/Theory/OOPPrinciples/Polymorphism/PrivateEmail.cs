using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.OOPPrinciples.Polymorphism
{
    public class PrivateEmail : Email
    {
        /// <summary>
        /// Overriding inherited function from Email
        /// </summary>
        public void SendEmail(string distributor)
        {
            Console.WriteLine("This email will be send only to my distributor");
        }
    }
}
