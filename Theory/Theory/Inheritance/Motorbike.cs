using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.Inheritance
{
    public class Motorbike : Vehicle // This is the DERIVED class
    {
        public Motorbike(string model, int topSpeed, int price) //Constructor with 3 arguments
        {
            this.Model = model;
            this.TopSpeed = topSpeed;
            this.Price = price;
        }
        public string Model { get; set; }

        public int TopSpeed { get; set; }   //Properties

        public int Price { get; set; }
    }
}
