using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.BuilderDesignPattern
{
    /// <summary>
    /// This is our Concrete Builder
    ///Concrete Builder is a class which implements the Builder (ICarBuilder)
    ///to create the product
    /// </summary>
    public class CarBuilder : ICarBuilder
    {
        Car car = new Car(); 

        public void AddModel()
        {
            car.Model = "CLA 200";
        }
        
        public void AddEngine()
        {
            car.Engine = "V8";
        }

        public void AddWheelsType()
        {
            car.WheelsType = WheelsType.OffRoad;
        }

        public void AddDoors()
        {
            car.NumberOfDoors = 4;
        }

        public Car GetCar()
        {
            return car;
        }
    }
}
