using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.SOLID_Principles.Dependency_Inversion_Principle
{
    public class DependencyInversionTheory
    {
        public void Execute()
        {
            IPerson client = Factory.CreatePerson();

            IProduct phone = Factory.CreateProduct();

            IEmail email = Factory.CreateEmail();
            email.SendConfirmationEmail(client);

            IShipping shipping = Factory.CreateDelivery();
            shipping.ShippingProduct();
            Console.ReadLine();
        }
    }
}
