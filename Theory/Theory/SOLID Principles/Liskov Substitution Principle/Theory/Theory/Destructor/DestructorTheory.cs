using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.Destructor
{
    /// <summary>
    /// A destructor is unique to its class, there cannot be more than one destructor in a class
    /// A destructor has no return type and has exactly the same name as the class name,
    /// but it is distinguished apart from a constructor becaus of the symbol(~) prefixed 
    /// to its name
    /// It cannot be inherited
    /// It is called when the program exits
    /// It is only used with classes
    /// Destructors are methods inside the class used to destroy instances 
    /// of that class, when they are no longer reachable
    /// We are using a destructor when our class is holding some resource that must
    /// be cleaned up when the object goes away.
    /// </summary>
    public class DestructorTheory
    {
        public void Execute()
        {
            Average myAverage = new Average(10, 5, 8);
            myAverage.MakeAverage();
        }
    }
}
