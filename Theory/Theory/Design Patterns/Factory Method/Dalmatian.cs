using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.Design_Patterns.Factory_Method
{
    /// <summary>
    /// This is our "ConcreteProduct", this is a class that implements the Product Interface
    /// </summary>
    public class Dalmatian : DogBreed
    {
        private string _breedType;
        private string _breedOrigin;
        private string _breedSpecialAbility;

        public Dalmatian()
        {
            _breedType = "Dalmatian";
            _breedOrigin = "Croatia";
            _breedSpecialAbility = "Dalmatians know no fear for fire";
        }

        public override string BreedType { get { return _breedType; } }

        public override string BreedOrigin { get { return _breedOrigin; } }

        public override string BreedSpecialAbility { get { return _breedSpecialAbility; } }


    }
}
