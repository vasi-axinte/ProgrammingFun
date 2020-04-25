using System;

namespace Theory.Interfaces
{
    public class SportWatch : IWatch  //Class SportWatch IMPLEMENTS the IWatch interface
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

            public string MaterialsQuality { get; set; }  //Properties

            public bool Digital { get; set; }

            public string AlarmSong { get; set; }

            public void ShowTime()   //This is the method from IWatch interface, here provide the method body 
            {
                 Console.WriteLine("00:00");
            }

            public void AlarmSing()   //This is the method from IAlarmClock interface, here provide the method body 
            {
                 Console.WriteLine("Buzz buzz buzz");
            }  
    }
}