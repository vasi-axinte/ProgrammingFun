using System;

namespace Theory.Interfaces
{
    /// <summary>
    /// Class SportWatch IMPLEMENTS the IWatch interface
    /// </summary>
    public class SportWatch : IWatch  
    {
        public SportWatch(string brand, string strap, string materials, bool digital, string alarmSong) //Constructor
        {
            this.Brand = brand;
            this.Strap = strap;
            this.MaterialsQuality = materials;
            this.Digital = digital;
            this.AlarmSong = alarmSong;
        }

            public string Brand { get; set; }

            public string Strap { get; set; }

            public string MaterialsQuality { get; set; }  

            public bool Digital { get; set; }

            public string AlarmSong { get; set; }

        /// <summary>
        /// This is the method from IWatch interface, here we provide the method body 
        /// </summary>
        public void ShowTime()   
        {
           Console.WriteLine("00:00");
        }

        /// <summary>
        /// This is the method from IAlarmClock interface, we here provide the method body 
        /// </summary>
        public void AlarmSing()   
        {
           Console.WriteLine("Buzz buzz buzz");
        }  
    }
}