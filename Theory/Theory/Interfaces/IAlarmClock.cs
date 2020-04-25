namespace Theory.Interfaces
{
    public interface IAlarmClock  //Interface
    {
        string AlarmSong { get; set; }   //property

        void AlarmSing(); //interface method
    }
}