using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.ClassesAndObjects
{
    public class CarBuilder //A class is a reference type. A reference type doesn`t store
                            //it`s value directly. Instead it stores the addres where the value is 
                            //being stored.
    {
         // a constructor can take 0 arguments too

        public CarBuilder(string color, string name)  //constructor with 2 arguments
        { 
            this.Color = color;
            this.Name = name;
        }   

        public CarBuilder(string color, string name, string engine)  //constructor with 3 arguments
        {
            this.Color = color;
            this.Name = name;
            this.Engine = engine ;
        }

        public void StartEngine()  //classes can contain methods
        {
            Console.WriteLine("Wrum wrum");
        }


        public string Color { get; set; }
        public string Name { get; set; }       //properties
        public string Engine { get; set; }
    }
}
