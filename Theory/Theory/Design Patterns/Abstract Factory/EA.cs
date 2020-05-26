using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.Design_Patterns.Abstract_Factory
{
    /// <summary>
    /// Concrete Factory
    /// This is a class which implements the Abstract Factory interface operations
    /// to create concrete products
    /// </summary>
    public class EA : IVideoGamesCompany
    {
        public ISinglePlayerGame GetSinglePlayerGame()
        {
            return new NeedForSpeed();
        }

        public IMultiPlayerGame GetMultiPlayerGame()
        {
            return new Battlefield();
        }
    }
}
