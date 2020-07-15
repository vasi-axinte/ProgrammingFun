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
    public class Mercedes : ICarBuilder
    {
        Car car = new Car();

        public void Model()
        {
            car.Model = "CLA 200";
        }
        
        public void AddEngine()
        {
            car.Engine = "V8";
        }

        public void AddTiers()
        {
            car.Tiers = "Sport";
        }

        public void AddDoors()
        {
            car.Doors = "4";
        }

        public void GetCar()
        {
            Console.WriteLine(car.Engine + " " + car.Model + " " + car.Doors + " " + car.Tiers);

        }
    }
}
