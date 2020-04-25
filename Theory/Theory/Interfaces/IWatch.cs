namespace Theory.Interfaces
{    //IWatch is the interface
    public interface IWatch : IAlarmClock  //IWatch IMPLEMENTS the IAlarmClock interfa
    //Interfaces can implement from other interfaces too. 
    //In our case,IWatch interface implements the IAlarmClock interface
    {
        //In an interface we can`t have public, because EVERYTHING in an interface is public
        string Brand { get; set; } 

        string Strap { get; set; }

        string MaterialsQuality { get; set; }   //properties

        bool Digital { get; set; } 

        void ShowTime();   //interface method ( methods don`t have a body in Interface )
    }
    //Interfaces contains no implementation. 
    //Interface is like a contract that says what the class that implements it must contain
}