﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.SOLID_Principles.Liskov_Substitution_Principle
{
    public class Captain : BaseSoldier, ICommander 
    {
        public void GiveCommands()
        {
            Console.WriteLine("I order you to...");
        }

        public void PromoteSoldier()
        {
            Console.WriteLine("I am promoting u to a higher rank!");
        }
    }
}