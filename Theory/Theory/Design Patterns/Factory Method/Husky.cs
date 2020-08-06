using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.DesignPatterns.FactoryMethod
{
    /// <summary>
    /// This is our "ConcreteProduct", this is a class that implements the Product Interface
    /// </summary>
    public class Husky : DogBreed
    {
        private string _breedType;
        private string _breedOrigin;
        private string _breedSpecialAbility;

        public Husky()
        {
            _breedType = "Husky";
            _breedOrigin = "Siberia";
            _breedSpecialAbility = "Huskies are very strong and they have a lot of stamina";
        }

        public override string BreedType { get { return _breedType; } }

        public override string BreedOrigin { get { return _breedOrigin; } }

        public override string BreedSpecialAbility { get { return _breedSpecialAbility; } }
    }
}
