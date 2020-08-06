using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Dependency Inversion Principle says that high-level classes should not depend
/// on low level classes
/// </summary>
namespace Theory.SOLIDPrinciples.DependencyInversionPrinciple
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
