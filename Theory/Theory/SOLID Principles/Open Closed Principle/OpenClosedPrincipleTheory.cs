using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.SOLID_Principles.Open_Closed_Principle
{
    /// <summary>
    /// Solid Principles are playing a key role in parallel development, flexibility,
    /// and testability.
    /// </summary>
    public class OpenClosedPrincipleTheory
    {
        /// <summary>
        /// O from SOLID stands for Open Closed Principle
        /// Any new functionality should be implemented by adding new classes or methods
        /// instead of changing the existing ones
        /// If we don`t respect Open Closed Principle we break the Single Responsability Principle too.
        /// </summary>
        public void Execute()
        {
            //Instead of creating a new Employee we are creating a new PermanentEmployee
            Employee employee1 = new PermanentEmployee("Axinte");
            employee1.CalculateSalary();

            //Instead of creating a new Employee we are creating a new InternshipEmployee
            Employee employee2 = new InternshipEmployee("Keeinin");
            employee2.CalculateSalary();

            Console.ReadLine();


        }
    }
}
