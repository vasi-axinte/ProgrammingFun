using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.Inheritance
{
    public class InheritanceTheory
    {
       public void Run()
        {
            Car myCar = new Car();
            myCar.ShowBrandDetails();  //Calling the ShowBrandDetails() from VehicleBrand class ( The BASE class )
            Console.WriteLine();   
            Console.WriteLine(myCar.brand+" "+myCar.model+" "+myCar.price);
            Console.WriteLine();

            Motorbike myBike = new Motorbike();
            myBike.ShowBrandDetails();
            Console.WriteLine(myBike.brand + " " + myBike.model + " " + myBike.price);
            Console.ReadLine();
        }    
    }
}
