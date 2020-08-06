using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.SOLIDPrinciples.LiskovSubstitutionPrinciple
{
    public class Soldier : BaseSoldier, IRecived
    {
        public  void ReciveCommands(string command)
        {
            this.Command = command;
            Console.WriteLine("YES SIR! I will {0}", command);
        }

        public string Command { get; set; }
    }
}
