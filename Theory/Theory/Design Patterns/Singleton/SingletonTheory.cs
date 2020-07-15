using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Singleton esures a class has only one instance and provides a global point of acces to it
/// In our example we have our singleton class Product. Singleton class ensures that this class has
/// only one instance, like this when we create another object of type Product, class Product 
/// won`t have an instance because it already had one when we created our first product.
/// </summary>
namespace Theory.Design_Patterns.Singleton
{
    public class SingletonTheory
    {
        public void Execute()
        {
            Product firstProduct = Product.GetInstance;
            firstProduct.DisplayProduct("bread");

            Product secondProduct = Product.GetInstance;
            secondProduct.DisplayProduct("coke");
            Console.ReadLine();
        }
    }
}
