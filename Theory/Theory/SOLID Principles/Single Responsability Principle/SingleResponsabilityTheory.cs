using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Solid Principles are playing a key role in parallel development, flexibility,
/// and testability.
/// </summary>
namespace Theory.SOLIDPrinciples.SingleResponsabilityPrinciple
{
    /// <summary>
    /// S from SOLID stands for Single Responsability Principle
    /// Each class should focus on a single task/responsability, everything in the class should be
    /// related to that single purpose
    /// By using Single Responsability Principle the code will be less fragile.
    /// </summary>
    public class SingleResponsabilityTheory
    {
        public void Execute()
        {
            User newUser = new User("Keeinin", "abc123");
            newUser.LoginUser();
            newUser.Register();

            Email verificationEmail = new Email();
            verificationEmail.SendVerificationEmail();

            Console.ReadLine();
        }
    }
}
