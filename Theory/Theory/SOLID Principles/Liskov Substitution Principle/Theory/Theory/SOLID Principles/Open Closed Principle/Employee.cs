﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.SOLID_Principles.Open_Closed_Principle
{
    /// <summary>
    /// Employee is our base class.
    /// </summary>
    public abstract class Employee
    {
        public Employee(string lastName)
        {
            this.LastName = lastName;
        }

        public abstract void CalculateSalary();
    
        public string LastName { get; set; }
    }
}