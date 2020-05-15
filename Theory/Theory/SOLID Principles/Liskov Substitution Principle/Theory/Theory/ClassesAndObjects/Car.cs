using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.ClassesAndObjects
{
    public class Car
    {
        /// <summary>
        /// A constructor can take 0 arguments too
        /// The constructor will be called when you create an object of type Car
        /// </summary>
        public Car(string color, string name)  
        {                                             
            this.Color = color;
            this.Name = name;
        }

        /// <summary>
        /// The constructor will be called when you create an object of type Car
        /// </summary>
        public Car(string color, string name, string engine)  
        {                      
            this.Color = color;
            this.Name = name;
            this.Engine = engine ;
        }

        /// <summary>
        /// //Classes can contain methods
        /// </summary>
        public void StartEngine() 
        {
            Console.WriteLine("Wrum wrum");
        }

        public string Color { get; set; }

        public string Name { get; set; }      

        public string Engine { get; set; }
    }
}