using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// LSP says: If S is subtype of T, then object of type T can be replaced with an object
/// of type S without breaking the program
/// </summary>
namespace Theory.SOLID_Principles.Liskov_Substitution_Principle
{
    public class LiskovSubstitutionTheory
    {
        public void Execute()
        {
            Commander ourCommander = new Commander();
            ourCommander.FirstName = "Ivar";
            ourCommander.LastName = "Lothbrok";
            ourCommander.Age = 27;
            ourCommander.ReciveCommands("Attack!");
            Console.WriteLine(ourCommander.FirstName);

            Soldier ourSoldier = new Commander();
            ourSoldier.FirstName = "Rollo";
            ourSoldier.LastName = "Lothbrok";
            ourSoldier.Age = 35;
            ourSoldier.ReciveCommands("Retreat!");
            Console.WriteLine(ourSoldier.FirstName);
            Console.ReadLine();

        }
        
    }
}
