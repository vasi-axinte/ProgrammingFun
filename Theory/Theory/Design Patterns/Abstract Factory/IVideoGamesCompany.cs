using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.Design_Patterns.Abstract_Factory
{
    /// <summary>
    /// Abstract Factory
    /// This is an intreface for operation which is used to create abstract product
    /// </summary>
    public interface IVideoGamesCompany
    {
        IMultiPlayerGame GetMultiPlayerGame();
        ISinglePlayerGame GetSinglePlayerGame();
    }
}
