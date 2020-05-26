using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.Design_Patterns.Factory_Method
{
    public abstract class DogBreedFactory 
    {
      public abstract DogBreed GetDogBreed();
    }
}
