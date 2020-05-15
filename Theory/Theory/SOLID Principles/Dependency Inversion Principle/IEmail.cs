using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.SOLID_Principles.Dependency_Inversion_Principle
{
    public interface IEmail 
    {
        void SendConfirmationEmail(IPerson client);
    }
}
