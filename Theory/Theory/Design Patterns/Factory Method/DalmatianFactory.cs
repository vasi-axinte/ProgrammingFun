using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.Design_Patterns.Factory_Method
{
    public class DalmatianFactory : DogBreedFactory
    {
        public override DogBreed GetDogBreed()
        {
            return new Dalmatian();
        }
    }
}
