using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.SOLID_Principles.Dependency_Inversion_Principle
{
    public interface IProduct
    {
        string ProductName { get; set; }

         bool Stock { get; set; }
    }
}
