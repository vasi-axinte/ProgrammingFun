using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.DesignPatterns.FactoryMethod
{
    /// <summary>
    /// This is our "Creator" class.This class will override the factory method to return an
    /// instance of ConcreteProduct (Husky or Pitbull or Dalmatian in our case)
    /// </summary>
    public class PitbullFactory : HuskyFactory
    {
        public override DogBreed GetDogBreed()
        {
            return new Pitbull();
        }
    }
}
