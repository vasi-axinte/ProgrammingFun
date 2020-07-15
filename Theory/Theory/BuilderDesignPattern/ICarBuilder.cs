using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.BuilderDesignPattern
{
    /// <summary>
    /// This is our "Builder"
    /// Builder, is an interface which is used to define all the steps required to
    /// create a product
    /// </summary>
    public interface ICarBuilder
    {
        void Model();
        void AddDoors();
        void AddEngine();
        void AddTiers();
        void GetCar();
    }
}
