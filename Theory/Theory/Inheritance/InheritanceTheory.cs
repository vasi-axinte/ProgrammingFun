using System;

namespace Theory.Inheritance
{
    public class InheritanceTheory
    {
       public void Execute()      /* Inheritance is a feature of object-oriented programming languages
                                  that allows us to define a base class that provides specific functionality
                                  and to define derived classes that can inherit or override that functionality */
        {
            Car myCar = new Car("m4" , "automatic" , 100000);
            myCar.ShowBrandDetails();  //Calling the ShowBrandDetails() from VehicleBrand class ( The BASE class ) on object myBike
            Console.WriteLine();   
            Console.WriteLine( myCar.Brand +" Model: "+ myCar.Model +" Price: "+ myCar.Price + " Gearbox: " + myCar.GearBox);
            //Display the value of the Brand ( from Vehicle class) and the value of Mode, Price and GearBox( from Car class) 

            Console.WriteLine();

            Motorbike myBike = new Motorbike("S1000RR", 303, 10000);
            myBike.ShowBrandDetails(); //Calling the ShowBrandDetails() from VehicleBrand class ( The BASE class ) on object myBike
            Console.WriteLine(myBike.Brand + " Model: " + myBike.Model + " Price: " + myBike.Price + " Top Speed: " + myBike.TopSpeed);
            Console.ReadLine();
        }    
    }
}
