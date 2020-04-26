using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.Inheritance
{
    /// <summary>
    /// Class Car inherit from class Vehicle. 
    /// Class Car will be called Child Class and Class Vehicle will be called Parent Class
    /// To inherit from a class we use ":" symbol
    /// </summary>
    public class Car : Vehicle  
    {
        /// <summary>
        /// Constructor with 3 arguments
        /// </summary>
        public Car(string model, string gearBox, int price)  
        {
            this.Model = model;
            this.GearBox = gearBox;
            this.Price = price;
        }

        public string Model { get; set; }

        public string GearBox { get; set; }  

        public int Price { get; set; }
    }
}