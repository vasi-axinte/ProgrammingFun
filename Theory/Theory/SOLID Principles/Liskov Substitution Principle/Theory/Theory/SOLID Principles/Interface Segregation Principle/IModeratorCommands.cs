using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.SOLID_Principles.Interface_Segregation_Principle
{
    interface IModeratorCommands
    {
        bool KickUser();

        bool GivePoints();

        bool GiveAccess();
    }
}
