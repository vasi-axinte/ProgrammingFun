using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.Design_Patterns.Abstract_Factory
{
    /// <summary>
    /// Product
    /// This class defines a product object to be created by the corresponding 
    /// concrete factory, it also implements the AbstractProduct interface
    /// </summary>
    public class Battlefield : IMultiPlayerGame
    {
        public string ShowGameDetails()
        {
            return "Battlefield is an FPS game";
        }
    }
}
