using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.Inheritance
{
    public class Vehicle       // This is the BASE class
    {
        public string brand = " BMW ";    //field
        public void ShowBrandDetails()   //method
        {
        Console.WriteLine("The company was founded in 1916 as a manufacturer of aircraft engines, which it produced from 1917 until 1918 and again from 1933 to 1945");
        }
    }
}
