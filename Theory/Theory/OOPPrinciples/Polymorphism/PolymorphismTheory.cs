using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.OOPPrinciples.Polymorphism
{
    /// <summary>
    /// The word polymorphism means having many form.
    /// In simple words, we cand describe polymorphis as the ability of a message to 
    /// be desplayed in more than one form
    /// </summary>
    public class PolymorphismTheory
    {
        //Functions that will be called here will depend on the parameters passed
        public void Execute()
        {
            Email myEmail = new Email();
            myEmail.SendEmail("Cristi");

            myEmail.SendEmail("Cristi", "Mihai");

            PrivateEmail specialEmail = new PrivateEmail();
            specialEmail.SendEmail("Axinte");

            Console.ReadLine();
        }
    }
}
