namespace Theory.Interfaces
{
    /// <summary>
    /// IWatch is the interface
    /// Interfaces can implement from other interfaces too. 
    /// In our case,IWatch interface implements the IAlarmClock interface.
    /// </summary>
    public interface IWatch : IAlarmClock  
    {
        /// <summary>
        /// In an interface we can`t have public, because EVERYTHING in an interface is public
        /// </summary>
        string Brand { get; set; } 

        string Strap { get; set; }

        string MaterialsQuality { get; set; }   

        bool Digital { get; set; }

        /// <summary>
        /// Interface methods ( methods don`t have a body in Interface )
        /// </summary>
        void ShowTime();  
    }
}