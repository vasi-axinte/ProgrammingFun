using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.Abstract_Classes_VS_Interfaces
{
    /// <summary>
    /// Abstraction is the process to hide the internal details and showing only the functionality.
    /// We use abstraction when we want to have a Class that only defines a generalized
    /// form that will be shared to other classes.
    /// </summary>
    public class AbstractClassesTheory
    {
        public void Execute()
        {
            KitchenRobot myKitchenRobot = new KitchenRobot();
            myKitchenRobot.ShowRobotMessage();

            Console.WriteLine(myKitchenRobot.Brand + " " + myKitchenRobot.RobotName);
            myKitchenRobot.ShowRobotUtility();
            Console.ReadLine();
        }
    }
}
