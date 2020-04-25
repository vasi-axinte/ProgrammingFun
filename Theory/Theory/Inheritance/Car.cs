using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.Inheritance
{
    public class Car : Vehicle  // This is the DERIVED Class(child class)
                            // To inherit from a class, we use the ":" symbol. 
                             //In our case we have the class Car( child class ) who inherit from 
                             //class Vehicle( parent class )
    {
        public Car(string model, string gearBox, int price)  //Constructor with 3 arguments
        {
            this.Model = model;
            this.GearBox = gearBox;
            this.Price = price;
        }

        public string Model { get; set; }

        public string GearBox { get; set; }   //Properties

        public int Price { get; set; }
    }
}