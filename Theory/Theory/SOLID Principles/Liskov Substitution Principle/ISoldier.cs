using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.SOLID_Principles.Liskov_Substitution_Principle
{
    public interface ISoldier
    {
        string FirstName { get; set; }

        string LastName { get; set; }

        int Age { get; set; }

    }
}
