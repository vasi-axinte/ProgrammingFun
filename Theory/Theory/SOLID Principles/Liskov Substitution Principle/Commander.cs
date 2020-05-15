using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.SOLID_Principles.Liskov_Substitution_Principle
{
    public class Commander : Soldier, ICommander
    {
        public void GiveCommands()
        {
            Console.WriteLine("I order you to...");
        }
    }
}
