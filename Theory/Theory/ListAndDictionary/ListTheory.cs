using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Theory.ListAndDictionary
{
    /// <summary>
    /// List is a class in C# and provides functionality to create a list of
    /// objects, find list items, sort list, search list, and manipulate list items.
    /// In our example we created 3 methods, one for adding elements to our list
    /// one for removing elements from our list, and the last one finds a specific
    /// element in our list
    /// </summary>
    public class ListTheory
    {
        List<Employee> internship = new List<Employee>();

        public void Execute()
        {
            AddEmployees();
            Console.WriteLine();
            RemoveEmployee();
            Console.WriteLine();
            FindEmployee();
            Console.ReadLine();
        }

        public void AddEmployees()
        {
            internship.Add(new Employee("Axinte", "Cristi"));
            internship.Add(new Employee("Mike", "Numbers"));
            internship.Add(new Employee("Black", "Sun"));
            internship.Add(new Employee("Toshi", "Nzz"));

            foreach (Employee internshipEmplyee in internship)
            {
                Console.WriteLine(internshipEmplyee.LastName + " " + internshipEmplyee.FirstName);
            }

            Console.WriteLine();
            internship.Insert(2, new Employee("Madi", "Sun"));

            foreach (Employee internshipEmplyee in internship)
            {
                Console.WriteLine(internshipEmplyee.LastName + " " + internshipEmplyee.FirstName);
            }
        }

        public void RemoveEmployee()
        {
            Console.WriteLine("Our list:");
            foreach (Employee internshipEmployee in internship)
            {
                Console.WriteLine(internshipEmployee.LastName + " " + internshipEmployee.FirstName);
            }
            Console.WriteLine("Now we start removing");

            Console.WriteLine();
            internship.RemoveAt(1);

            foreach (Employee internshipEmployee in internship)
            {
                Console.WriteLine(internshipEmployee.LastName + " " + internshipEmployee.FirstName);
            }

            Console.WriteLine();
            internship.RemoveRange(2, 1);

            foreach (Employee internshipEmployee in internship)
            {
                Console.WriteLine(internshipEmployee.LastName + " " + internshipEmployee.FirstName);
            }
        }

        public void FindEmployee()
        {
            Console.WriteLine("Our list");
            foreach (Employee internshipEmployee in internship)
            {
                Console.WriteLine(internshipEmployee.LastName + " " + internshipEmployee.FirstName);
            }
          Console.WriteLine("We found our employee:{0}", internship.Find(failure => failure.LastName.Contains("Axinte")).FirstName);
        }
    }
}
