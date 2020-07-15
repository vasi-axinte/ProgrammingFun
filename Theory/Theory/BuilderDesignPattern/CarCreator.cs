using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.BuilderDesignPattern
{
    /// <summary>
    /// This is our Director
    /// Director is a class that is used to construct an object using the Builder interface
    /// </summary>
    public class CarCreator
    {
        private ICarBuilder _carBuilder;

        public CarCreator(ICarBuilder carBuilder)
        {
            _carBuilder = carBuilder;
        }

        public void CreateCar()
        {
            _carBuilder.AddEngine();
            _carBuilder.AddTiers();
            _carBuilder.AddDoors();
            _carBuilder.Model();
        }

        public void GetCar()
        {
             _carBuilder.GetCar();
        }
    }
}
