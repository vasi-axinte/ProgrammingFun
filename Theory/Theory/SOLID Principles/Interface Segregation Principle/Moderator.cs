using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.SOLIDPrinciples.InterfaceSegregationPrinciple
{
    /// <summary>
    /// Moderator class implements both interfaces because he has a higer rank than a 
    /// normal user, so he has access to both types of commands
    /// </summary>
    public class Moderator : IModeratorCommands, IUserCommands
    {
        public bool KickUser()
        {
            Console.WriteLine("I can kick u");
            return true;
        }

        public bool GivePoints()
        {
            Console.WriteLine("I can give u points ;)");
            return true;
        }

        public bool GiveAccess()
        {
            Console.WriteLine("I can give u access to some special contnent");
            return true;
        }

        public bool WriteInChat()
        {
            Console.WriteLine("I can write in chat too");
            return true;
        }

        public bool UseEmote()
        {
            Console.WriteLine("I can use emotes too");
            return true;
        }
    }
}
