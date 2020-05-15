using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.SOLID_Principles.Dependency_Inversion_Principle
{
    public class Shipping : IShipping
    {
        IPerson _client;
       
        
        public Shipping(IPerson client)
        {
            _client = client;
        }

        public void ShippingProduct()
        {
            Console.WriteLine("We are shiping the product to:{0}", _client.LastName);
            Console.WriteLine("Who lives in {0}", _client.Address);
        }
    }
}
