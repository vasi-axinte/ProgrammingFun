using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.Design_Patterns.Singleton
{
    public sealed class Product
    {
        private static Product instance = null;
        public static Product GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new Product();
                return instance;
            }
        }
       
        /// <summary>
        /// constructor with 0 parameters
        /// </summary>
        private Product()
        {
            Console.WriteLine("Products list:");
        }

        public void DisplayProduct(string product)
        {
            Console.WriteLine(product);
        }
    }
}
