using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.AbstractClassesVSInterfaces
{
    /// <summary>
    /// We cannot acces the abstract class directly with the new operator. 
    /// To acces the abstract class we have to use inheritance
    /// Class KitchenRobot inherits abstract class Robot
    /// </summary>
    public class KitchenRobot : Robot
    {
        public KitchenRobot()
        {
            this.Brand = "Samsung";
            this.RobotName = "Kitchen Robot";
        }
        /// <summary>
        /// Overriding the abstract method ShowRobotUtility, using the override keyword 
        /// </summary>
        public override void ShowRobotUtility()
        {
            Console.WriteLine("This robot can cut fruits");
        }

        /// <summary>
        /// Overriding abstract properties
        /// </summary>
        public override string Brand { get; set; }

        public override string RobotName { get; set; }
    }
}
