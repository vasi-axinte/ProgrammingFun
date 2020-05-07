using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.SOLID_Principles.Interface_Segregation_Principle
{
    public interface IUserCommands
    {
        bool WriteInChat();

        bool UseEmote();
    }
}
