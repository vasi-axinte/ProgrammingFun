using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.Design_Patterns.Factory_Method
{
    /// <summary>
    /// Factory method is a design Pattern which defines an interface for creating an
    /// object but lets the classes that implement the interface decide which class to instantiate
    /// In our example we have 3 different dog breeds(Husky, Dalmatian, Pitbull) all of them 
    /// implement the abstract class DogBreed. We need to instantiate one of those classes, but
    /// we don`t know which one, because it depends on the user, on the client that wants to
    /// know more about one of those breeds.
    /// </summary>
    public class FactoryMethodThoery
    {
        public void Execute()
        {
            DogBreedFactory factory = null;
            Console.WriteLine("Enter the breed type you would like to get more details about");
            string breedType = Console.ReadLine();
            breedType.ToLower();

            if (breedType == "dalmatian")
            {
                factory = new DalmatianFactory();
            }

            if (breedType == "husky")
            {
                factory = new HuskyFactory();
            }

            if (breedType == "pitbull")
            {
                factory = new PitbullFactory();
            }
            
            DogBreed dogBreed = factory.GetDogBreed();
            Console.WriteLine("\nBreed Details:");
            Console.WriteLine("Breed Type: {0} \nBreed Origin: {1} \nBreed Special Ability: {2}", dogBreed.BreedType, dogBreed.BreedOrigin, dogBreed.BreedOrigin);
            Console.ReadLine();            
        }
    }
}
