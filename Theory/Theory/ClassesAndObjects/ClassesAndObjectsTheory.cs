using System;

namespace Theory.ClassesAndObjects
{
    class ClassesAndObjectsTheory
    {
         public void Execute()
         {
            //A class is like a blueprint that specifies what the type can do.
            //An object is a block of memory that has been allocated and configured according to the blueprint(Class)
           
            Car myFirstCar = new Car("White", "BMW"); //Declaring new object myCar of type CarBuilder
            Console.WriteLine(myFirstCar.Color +" "+ myFirstCar.Name);
            myFirstCar.StartEngine(); 
            Console.WriteLine();

            Car mySecondCar = new Car("Black","ford", "V8");  //Declaring new object mySecondCar of type CarBuilder    
            Console.WriteLine(mySecondCar.Color +" "+ mySecondCar.Name +" "+ mySecondCar.Engine); //Displaying on screen car details

            Car myThirdCar = myFirstCar; //We are assigning a new object called myThirdCar to object MyCar of the same type
                                         //This will create another reference that points to the same object that myCar does, this is happening because Class is a reference type.
            Console.WriteLine(myThirdCar.Color + " " + myThirdCar.Name);
            Console.WriteLine();

            if (myThirdCar.Equals(myFirstCar))     //We are using Equals to determinate whether class objects refer to the same location in memory
                                                   //(which means that they have the same identity)
            {
                Console.WriteLine("myThirdCar and myFirstCar have the same values");     
            }
            Console.ReadLine();
         }
    }
}             
                                     //ClassesAndObjects
                //The Objects are created from Classes, u can see the Classes as a blueprint.
                //For example u want to build a House ( this is our object ) we will build
                //our house according to the blueprint( this is our Class). 
                //every aspect of the house (object) will be found in our blueprint(class).