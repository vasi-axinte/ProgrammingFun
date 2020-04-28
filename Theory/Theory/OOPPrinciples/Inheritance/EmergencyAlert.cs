using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.OOPPrinciples.Inheritance
{
    /// <summary>
    /// Parent class.
    ///Parent class EmergencyAlert will share with his child classes(EarthquakeAlert, TsunamiAlert)
    ///his methods, and properties.
    /// </summary>
    public class EmergencyAlert
    {
       public void ShowAlertMessage()
       {
            Console.WriteLine("THIS IS AN EMERGENCY!!");
       }

        protected int EmergencyGrade { get; set; }

        protected string EmergencyMessage { get; set; }

        protected string EmergencyCause { get; set; }
    }
}
