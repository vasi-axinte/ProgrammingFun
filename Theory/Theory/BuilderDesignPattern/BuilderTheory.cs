using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.BuilderDesignPattern
{
    /// <summary>
    /// Builder desing pattern is used to build a complex object by using step by step approach
    /// and the final step returns the object
    /// </summary>
    public class BuilderTheory
    {
        public void Execute()
        {
            var BuildMercedes = new CarCreator(new Mercedes());
            BuildMercedes.CreateCar();
            BuildMercedes.GetCar();
            Console.ReadLine();
        }
    }
}
