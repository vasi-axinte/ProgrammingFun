using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.DesignPatterns.Abstract_Factory
{
    /// <summary>
    /// Product
    /// This class defines a product object to be created by the corresponding 
    /// concrete factory, it also implements the AbstractProduct interface
    /// </summary>
    public class WorldOfWarcraft : IMultiPlayerGame
    {
        public string ShowGameDetails()
        {
           return "World of Warcraft is a MMORPG game";
        }
    }
}
