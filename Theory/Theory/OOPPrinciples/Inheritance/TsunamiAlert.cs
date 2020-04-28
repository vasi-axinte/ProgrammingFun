using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.OOPPrinciples.Inheritance
{
    /// <summary>
    /// EarthquakeAlert inherits all properties and methods from his parent class ( EmergencyAlert)
    /// </summary>
    public class TsunamiAlert : EmergencyAlert
    {
        /// <summary>
        /// Because class TsunamiAlert inherits all the properties from EmergencyAlert
        /// we don`t have to declare them again. We are just assign them some values;
        /// </summary>
        public void ShowAlertDetails()
        {
            EmergencyGrade = 9;
            EmergencyMessage = "Please leave the city!";
            EmergencyCause = "Tsunami";

            Console.WriteLine("Emergency cause:" + EmergencyCause + " " +"EmergencyGrade:" + EmergencyGrade + " " + "EmergencyMessage:" + EmergencyMessage);
        }
    }
}
