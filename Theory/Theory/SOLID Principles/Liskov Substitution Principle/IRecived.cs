using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.SOLIDPrinciples.LiskovSubstitutionPrinciple
{
    public interface IRecived
    {
        string Command { get; set; }

        void ReciveCommands(string command);
    }
}
