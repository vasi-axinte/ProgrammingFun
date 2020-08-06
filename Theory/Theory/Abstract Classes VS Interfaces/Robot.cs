using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.AbstractClassesVSInterfaces
{
    /// <summary>
    /// I want this class to be only a base class for other classes so,
    /// i will use abstract modifier
    /// Abstract classes cannot be instantiated, the purpose of an abstract class
    /// is to provide a common definition of a base class (Robot in our case) 
    /// that multiple derived classes can share.
    /// </summary>
    public abstract class Robot
    {
        public abstract string RobotName { get; set; }

        public abstract string Brand { get; set; }

        /// <summary>
        /// Abstract methods can only be used in an abstract class, and it does not have a body
        /// The body is provided by the derived class
        /// You are not allowed to declare the abstract methods outside the abstract class
        /// </summary>
        public abstract void ShowRobotUtility();

        /// <summary>
        /// Abstract can have methods that are not abstract, and for those, we can 
        /// declare their body here.
        /// </summary>
        public void ShowRobotMessage()
        {
            Console.WriteLine("Hi, i am a robot!");
        }
    }
}
