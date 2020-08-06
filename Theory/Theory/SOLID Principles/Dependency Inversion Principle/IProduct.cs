using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.SOLIDPrinciples.DependencyInversionPrinciple
{ 
    public interface IProduct
    {
        string ProductName { get; set; }

         bool Stock { get; set; }
    }
}
