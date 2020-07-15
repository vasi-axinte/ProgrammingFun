﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.BuilderDesignPattern
{

    /// <summary>
    /// This is our Product
    /// Product, is a class which defines the parts of the complex object
    /// </summary>
    public class Car 
    {
       public string Model { get; set; }

       public string Doors { get; set; }

       public string Engine { get; set; }

       public string Tiers { get; set; }
    }
}
