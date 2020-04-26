using System;

namespace Theory.ClassesAndObjects
{
    /// <summary>
    /// The Objects are created from Classes, u can see the Classes as a blueprint.
    /// For example u want to build a House ( this is our object ) we will build our house according 
    /// to the blueprint( this is our Class). Every aspect of the house (object) will be found in our blueprint(class).
    /// </summary>

    /// <summary>
    /// A class is a reference type. A reference type doesn`t store it`s value directly
    /// Instead it stores the addres where the value is being stored
    /// </summary>
    /// An object is a block of memory that has been allocated and configured according to the blueprint(Class)

    class ClassesAndObjectsTheory
    {
           public void Execute()
           {
                //Declaring new object myCar of type CarBuilder
                Car myFirstCar = new Car("White", "BMW"); 
                Console.WriteLine(myFirstCar.Color +" "+ myFirstCar.Name);
                myFirstCar.StartEngine(); 
                Console.WriteLine();
              
                //Declaring new object mySecondCar of type CarBuilder 
                Car mySecondCar = new Car("Black","ford", "V8");     
                Console.WriteLine(mySecondCar.Color +" "+ mySecondCar.Name +" "+ mySecondCar.Engine); //Displaying on screen car details

                //We are assigning a new object called myThirdCar to object MyCar of the same type
                //This will create another reference that points to the same object that myCar does, this is happening because Class is a reference type.
                Car myThirdCar = myFirstCar;
                                         
                Console.WriteLine(myThirdCar.Color + " " + myThirdCar.Name);
                Console.WriteLine();

                //We are using Equals to determinate whether class objects refer to the same location in memory
                //(which means that they have the same identity)
                if (myThirdCar.Equals(myFirstCar))     
                {
                    Console.WriteLine("myThirdCar and myFirstCar have the same values");     
                }
                Console.ReadLine();
           }
    }
}