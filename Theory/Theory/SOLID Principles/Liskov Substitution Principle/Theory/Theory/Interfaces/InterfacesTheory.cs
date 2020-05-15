using System;

namespace Theory.Interfaces
{
    /// <summary>
    /// Interfaces contains no implementation. 
    /// An Interface is like a contract that says what the class that implements it must contain
    /// </summary>
    public class InterfacesTheory
    {
        public void Execute()
        {
            ClassicWatch myWatch = new ClassicWatch("Seiko", "Leather", "High", false, "Wake me up", true);
            Console.WriteLine("Brand:" + myWatch.Brand + " " + "Strap:" + myWatch.MaterialsQuality + " " + "Digital:" + myWatch.Digital + " " + "Alarm song is:" + myWatch.AlarmSong);
            
            // calling ShowTime method from class ClassicWatch
            myWatch.ShowTime();
           
            //calling ShowTime method from class ClassicWatch
            myWatch.AlarmSing(); 

            SportWatch myFriendsWatch = new SportWatch("Casio", "Metal", "Medium", true, "Ring the Alarm");
            Console.WriteLine("Brand:" + myFriendsWatch.Brand + " " + "Strap:" + myFriendsWatch.MaterialsQuality + " " + "Digital:" + myFriendsWatch.Digital + " " + "Alarm song is:" + myFriendsWatch.AlarmSong);

            //calling ShowTime method from class SportWatch
            myFriendsWatch.ShowTime();

            //calling ShowTime method from class ClassicWatch
            myWatch.AlarmSing(); 

            Console.ReadLine();
        }
    }
}