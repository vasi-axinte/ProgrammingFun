using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.SOLIDPrinciples.InterfaceSegregationPrinciple
{
    interface IModeratorCommands
    {
        bool KickUser();

        bool GivePoints();

        bool GiveAccess();
    }
}
