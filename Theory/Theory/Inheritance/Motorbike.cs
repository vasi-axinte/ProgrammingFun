namespace Theory.Inheritance
{
    /// <summary>
    ///  Motorbike class inherits from Vehicle class
    /// </summary>
    public class Motorbike : Vehicle 
    {
        /// <summary>
        ///  ///Constructor with 3 arguments
        /// </summary>
        public Motorbike(string model, int topSpeed, int price) 
        {
            this.Model = model;
            this.TopSpeed = topSpeed;
            this.Price = price;
        }
        public string Model { get; set; }

        public int TopSpeed { get; set; }   

        public int Price { get; set; }
    }
}
