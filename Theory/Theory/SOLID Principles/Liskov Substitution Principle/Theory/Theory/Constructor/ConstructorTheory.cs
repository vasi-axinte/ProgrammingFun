using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.Constructor
{
    /// <summary>
    /// A constructor is a method whose name is the same as the name of its type. 
    /// A constructor does not include a return type
    /// A constructor method signature includes only the method name and its parameter list.
    /// A constructor initialize the new object, a constructor sets the startup property values
    /// for the object.
    /// </summary>
    public class ConstructorTheory
    {
        public void Execute()
        {
            Person person1 = new Person();
            Console.WriteLine(person1.LastName +" "+ person1.FirstName +" "+ person1.Age);

            Person person2 = new Person("Mihai", "Ionel", 13);
            Console.WriteLine(person2.LastName +" "+ person2.FirstName +" "+ person2.Age);
            Console.ReadLine();
        }
    }
}
