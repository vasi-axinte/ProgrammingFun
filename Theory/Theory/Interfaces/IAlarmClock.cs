namespace Theory.Interfaces
{
    /// <summary>
    /// This is our Interface
    /// </summary>
    public interface IAlarmClock  
    {
        string AlarmSong { get; set; }   

        void AlarmSing(); 
    }
}