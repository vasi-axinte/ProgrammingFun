using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.SOLID_Principles.Dependency_Inversion_Principle
{
    public class ConfirmationEmail : IEmail
    {
        public void SendConfirmationEmail(IPerson client)
        {
            Console.WriteLine("Your product has been delivered!");
            Console.WriteLine("We are sending more information to:{0}", client.Email );
        }
    }
}
