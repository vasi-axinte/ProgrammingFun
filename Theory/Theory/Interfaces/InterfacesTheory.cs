using System;

namespace Theory.Interfaces
{
    public class InterfacesTheory
    {
        public void Execute()
        {
            ClassicWatch myWatch = new ClassicWatch("Seiko", "Leather", "High", false, "Wake me up", true);
            Console.WriteLine("Brand:" + myWatch.Brand + " " + "Strap:" + myWatch.MaterialsQuality + " " + "Digital:" + myWatch.Digital + " " + "Alarm song is:" + myWatch.AlarmSong);
            myWatch.ShowTime(); //calling ShowTime method from class ClassicWatch
            myWatch.AlarmSing(); //calling ShowTime method from class ClassicWatch

            SportWatch myFriendsWatch = new SportWatch("Casio", "Metal", "Medium", true, "Ring the Alarm");
            Console.WriteLine("Brand:" + myFriendsWatch.Brand + " " + "Strap:" + myFriendsWatch.MaterialsQuality + " " + "Digital:" + myFriendsWatch.Digital + " " + "Alarm song is:" + myFriendsWatch.AlarmSong);
            myFriendsWatch.ShowTime(); //calling ShowTime method from class SportWatch
            myWatch.AlarmSing(); //calling ShowTime method from class ClassicWatch

            Console.ReadLine();
        }
    }
}