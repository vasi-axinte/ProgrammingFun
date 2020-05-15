using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.SOLID_Principles.Dependency_Inversion_Principle
{
    public interface IPerson
    {
         string FirstName { get; set; }

         string LastName { get; set; }

         string Email { get; set; }

         string Address { get; set; }
    }
}
