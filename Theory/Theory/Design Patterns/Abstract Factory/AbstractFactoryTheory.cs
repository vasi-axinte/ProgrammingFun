using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Abstract factory is an interface for creating families of related objects without 
/// specifying their concerete classes
/// We can say that it is an object maker which can create more than one type of object
/// In our case, we have IVideoGamesCompany interface who can create objects of type Blizzard and EA
/// </summary>
namespace Theory.DesignPatterns.Abstract_Factory
{
    public class AbstractFactoryTheory
    {
        public void Execute()
        {
            IVideoGamesCompany blizzardGames = new Blizzard();
            Gamer ourGamer = new Gamer(blizzardGames);

            Console.WriteLine(ourGamer.GetMultiPlayerGameDetails());
            Console.WriteLine(ourGamer.GetSinglePlayerGameDetails());
            Console.WriteLine();

            IVideoGamesCompany eaGames = new EA();
            Gamer ourSecondGamer = new Gamer(eaGames);

            Console.WriteLine(ourSecondGamer.GetMultiPlayerGameDetails());
            Console.WriteLine(ourSecondGamer.GetSinglePlayerGameDetails());
            Console.ReadLine();
        }
    }
}
