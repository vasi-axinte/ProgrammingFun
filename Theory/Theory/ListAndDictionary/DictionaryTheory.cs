using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.ListAndDictionary
{
    /// <summary>
    /// Dictionary class constructor takes a key data type and a value data type
    /// Each key must be unique in the cllection
    /// The difference between List and Dictionary is the fact that
    /// the items of a list comes in a specific order and cann be accesed by a
    /// numerical index, where items in a Dictionary is stored with unique key
    /// </summary>
    public class DictionaryTheory
    {
        Dictionary<string, string> employeesList = new Dictionary<string, string>();

        public void Execute()
        {
            AddEmployees();
            CountEmployees();
            CheckIfExists();
            CheckIfRoleExists();
            Console.ReadLine();
        }

        public void AddEmployees()
        {
            employeesList.Add("Axinte", "Worker");
            employeesList.Add("Mihai", "Architect");
            employeesList.Add("Cristi", "Manager");

            foreach(KeyValuePair<string, string> employee in employeesList)
            {
                Console.WriteLine(employee.Key + " " + employee.Value);
            }
        }

        public void CountEmployees()
        {
            Console.WriteLine("There are {0} employees", employeesList.Count);
        }

        public void RemoveEmployee()
        {
            employeesList.Remove("Axinte");
        }
         
        public void CheckIfExists()
        {
            if(employeesList.ContainsKey("Cristi"))
            {
                Console.WriteLine("We found Cristi in our Dictionary!");
            }
        }

        public void CheckIfRoleExists()
        {
            if(employeesList.ContainsValue("Manager"))
            {
                Console.WriteLine("We have a manager!");
            }
        }
    }
}
