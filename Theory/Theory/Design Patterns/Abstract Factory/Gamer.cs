using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.Design_Patterns.Abstract_Factory
{
    /// <summary>
    /// This class uses AbstractFactory and AbstractProduct interfaces to create
    /// a family of related objects
    /// </summary>
    public class Gamer
    {
        ISinglePlayerGame _singlePlayerGame;
        IMultiPlayerGame _multiPlayerGame;

        public Gamer(IVideoGamesCompany company)
        {
            _singlePlayerGame = company.GetSinglePlayerGame();
            _multiPlayerGame = company.GetMultiPlayerGame();
        }

        public string GetSinglePlayerGameDetails()
        {
            return _singlePlayerGame.ShowGameDetails();
        }

        public string GetMultiPlayerGameDetails()
        {
            return _multiPlayerGame.ShowGameDetails();
        }
    }
}
