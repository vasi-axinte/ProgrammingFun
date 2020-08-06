using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.SOLIDPrinciples.SingleResponsabilityPrinciple
{
    /// <summary>
    /// Email class performs ONLY email related tasks/responsabilites
    /// </summary>
    public class Email
    {
        public void SendVerificationEmail()
        {
            Console.WriteLine("We are sending an verification email to our new User");
        }
    }
}
