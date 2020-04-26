using System;

namespace Theory.Inheritance
{
    /// <summary>
    /// Inheritance is a feature of object-oriented programming languages
    /// that allows us to define a base class that provides specific functionality
    /// and to define derived classes that can inherit or override that functionality
    /// </summary>
 
    public class InheritanceTheory
    {
        public void Execute()  
        {
            //Declaring new object myCar of type Car
            Car myCar = new Car("m4" , "automatic" , 100000);

            //Calling the ShowBrandDetails() from VehicleBrand class ( The BASE class ) on object myBike
            myCar.ShowBrandDetails();

            //Display the value of the Brand ( from Vehicle class) and the value of Mode, Price and GearBox( from Car class) 
            Console.WriteLine( myCar.Brand +" Model: "+ myCar.Model +" Price: "+ myCar.Price + " Gearbox: " + myCar.GearBox);
            Console.WriteLine();


            //Declaring new object myBike of type Motorbike
            Motorbike myBike = new Motorbike("S1000RR", 303, 10000);

            //Calling the ShowBrandDetails() from VehicleBrand class ( The BASE class ) on object myBike
            myBike.ShowBrandDetails();

            Console.WriteLine(myBike.Brand + " Model: " + myBike.Model + " Price: " + myBike.Price + " Top Speed: " + myBike.TopSpeed);
            Console.ReadLine();
        }    
    }
}
