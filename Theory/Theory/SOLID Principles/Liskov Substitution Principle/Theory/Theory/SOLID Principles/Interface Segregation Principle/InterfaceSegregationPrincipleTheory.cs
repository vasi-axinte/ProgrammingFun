using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Solid Principles are playing a key role in parallel development, flexibility,
/// and testability.
/// </summary>
namespace Theory.SOLID_Principles.Interface_Segregation_Principle
{
    /// <summary>
    /// I from SOLID stands for Interface Segregation Principle
    /// We had one big interface called IUserCommands which defined what commands
    ///our users have. But a simple user isn`t able to kick/ban other user.
    ///So we will use Segregation Principle and we will segregate our big interface 
    ///in multiple interfaces, like this we obtain IUserCommands and IModeratorCommands.
    /// </summary>
    public class Interface_Segregation_Principle_Theory
    {
        public void Execute()
        {
            Console.WriteLine("This is what an user can do");
            User firstUser = new User();
            firstUser.WriteInChat();
            firstUser.UseEmote();
            Console.WriteLine();

            Console.WriteLine("This is what a moderator can do");
            Moderator firstModerator = new Moderator();
            firstModerator.KickUser();
            firstModerator.GivePoints();
            firstModerator.GiveAccess();
            firstModerator.UseEmote();
            firstModerator.WriteInChat();

            Console.ReadLine();
        }
    }
}
