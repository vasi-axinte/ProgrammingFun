using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.OOPPrinciples.Polymorphism
{
    /// <summary>
    /// The word polymorphism means having many form.
    /// In simple words, we can describe polymorphis as the ability of a message to 
    /// be desplayed in more than one form
    /// Polymorphis is usefull when we have  multiple classes who inherits
    /// Overriding is a type of polymorphism
    /// from the same parent
    /// </summary>
    public class PolymorphismTheory
    {
        /// <summary>
        //Functions that will be called here will depend on the parameters passed
        /// </summary>
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
