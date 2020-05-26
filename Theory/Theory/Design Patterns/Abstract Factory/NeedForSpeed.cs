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
    public class NeedForSpeed : ISinglePlayerGame
    {
        public string ShowGameDetails()
        {
          return "Need For Speed is a car racing game";
        }
    }
}
