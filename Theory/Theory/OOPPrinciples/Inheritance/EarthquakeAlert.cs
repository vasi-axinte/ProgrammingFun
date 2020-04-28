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
    public class EarthquakeAlert : EmergencyAlert
    {
        /// <summary>
        /// Because class EarthquakeAlert inherits all the properties from EmergencyAlert
        /// we don`t have to declare them again. We are just assign them some values;
        /// </summary>
        public void ShowAlertDetails()
        {
             EmergencyGrade = 5;
             EmergencyMessage = " Please remain calm";
             EmergencyCause = "Earthquake";

             Console.WriteLine("Emergency cause:" + EmergencyCause + " " + "EmergencyGrade:" + EmergencyGrade + " " + "EmergencyMessage:" + EmergencyMessage);
        }
    }
}
