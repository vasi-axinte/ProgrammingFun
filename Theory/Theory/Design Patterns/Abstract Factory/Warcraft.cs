using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.DesignPatterns.Abstract_Factory
{
    /// <summary>
    /// Prodcut
    /// This class defines a product object to be created by the corresponding 
    /// concrete factory, it also implements the AbstractProduct interface
    /// </summary>
    public class Warcraft : ISinglePlayerGame
    {
        public string ShowGameDetails()
        {
            return "Warcraft is a strategy game";
        }
    }
}
