using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.SOLID_Principles.Liskov_Substitution_Principle
{
    public interface ICommander : ISoldier
    {
        void GiveCommands();
    }
}
