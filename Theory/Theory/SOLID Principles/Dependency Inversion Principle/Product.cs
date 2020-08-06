﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.SOLIDPrinciples.DependencyInversionPrinciple
{
    public class Product : IProduct
    {
        public Product(string productName, bool stock)
        {
            this.ProductName = productName;
            this.Stock = stock;
        }
        public string ProductName { get; set; }

        public bool Stock { get; set; }
    }
}
