using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.SOLIDPrinciples.InterfaceSegregationPrinciple
{
    /// <summary>
    /// Class User implements only IUserCommands.
    /// </summary>
    public class User : IUserCommands
    {
        public bool WriteInChat()
        {
            Console.WriteLine("I can write in chat");
            return true;
        }
        public bool UseEmote()
        {
            Console.WriteLine("I can use emotes");
            return true;
        }
    }
}
