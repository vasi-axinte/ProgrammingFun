using System;

namespace Theory.Interfaces
{
    public class ClassicWatch : IWatch //Class ClassicWatch IMPLEMENTS the IWatch interface
  //When a class IMPLEMENTS the interface, the class MUST contain EVERYTHING that the Interface contains
   //or the program will show an error
    {
        public ClassicWatch(string brand, string strap, string materials, bool digital, string alarmSong, bool mechanical) //constructor
        {
            this.Brand = brand;
            this.Strap = strap;
            this.MaterialsQuality = materials;
            this.Digital = digital;
            this.AlarmSong = alarmSong;
            this.Mechanical = mechanical;
        }

      public string Brand { get; set; }

      public string Strap { get; set; }

      public string MaterialsQuality { get; set; } //Properties

      public bool Digital { get; set; }

      public string AlarmSong { get; set; }

      public bool Mechanical { get; set; }  //Property that only exists in class ClassicWatch 

        //We can add new properties in our class, and the interface won`t have any problems with that,
        //if the class contain everything that the interface contains

        public void ShowTime()  //This is the method from IWatch interface, here provide the method body 
      { 
            Console.WriteLine("13:00");   
      }

        public void AlarmSing()      //This is the method from IAlarmClock interface, here provide the method body 
        {
            Console.WriteLine("Buzz buzz buzz"); 
        }
    }
}   //We say that a class IMPLEMENTS the interface not INHERITS the interface because a class can`t have
    //multiple inheritances, but it can IMPLEMENT multiple interfaces.