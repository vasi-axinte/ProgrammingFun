using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.Design_Patterns.Factory_Method
{
    public class PitbullFactory : HuskyFactory
    {
        public override DogBreed GetDogBreed()
        {
            return new Pitbull();
        }
    }
}
