using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.OOPPrinciples.Inheritance
{
    /// <summary>
    /// Inheritance is one of the fundamental attibutes of OOP.
    /// Inheritance allows us to create a child class that inherits the functionality or
    /// ovveride the functionality of its parent class
    /// Inheritance is " is a " relation. In our case, EarthquakeAlert is a EmergencyAlert
    /// and TsunamyAlart is a EmergencyAlert. Both classes will inherit EmergencyAlert
    /// We use inheritance when we want to reuse some of the methods or properties from an
    /// existing class 
    /// </summary>
    public class InheritanceThoery
    {
        /// <summary>
        /// ShowAlertMessage method who is used by TsunamiAlert and EarthquakeAlert
        /// is inherited from their parent class EmergencyAlert
        /// </summary>
        public void Execute()
        {
            TsunamiAlert tsunami = new TsunamiAlert();
            tsunami.ShowAlertMessage();
            tsunami.ShowAlertDetails();

            EarthquakeAlert earthquake = new EarthquakeAlert();
            earthquake.ShowAlertMessage();
            earthquake.ShowAlertDetails();

            Console.ReadLine();
        }
    }
}
