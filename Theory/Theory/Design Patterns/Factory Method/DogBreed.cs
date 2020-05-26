using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.Design_Patterns.Factory_Method
{
    /// <summary>
    /// This is our "Product", this will define the interface of objects the factory method crates
    /// </summary>
    public abstract class DogBreed
    {
       public abstract string BreedType { get;  }

       public abstract string BreedOrigin { get;  }

       public abstract string BreedSpecialAbility { get; }
    }
}
