using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.Design_Patterns.Factory_Method
{
    /// <summary>
    /// This is an abstract class that declares the FACTORY METHOD which returns an object of our 
    /// product type (DogBreed in our case)
    /// </summary>
    public abstract class DogBreedFactory 
    {
       public abstract DogBreed GetDogBreed();
    }
}
