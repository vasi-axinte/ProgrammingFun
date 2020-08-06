using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.SOLIDPrinciples.DependencyInversionPrinciple
{
    public class Factory
    {
        public static IPerson CreatePerson()
        {
            return new Person("Cristi", "Axinte", "gmail@123.com", "Carei");
        }

        public static IProduct CreateProduct()
        {
            return new Product("Huawei", true);
        }

        public static IEmail CreateEmail()
        {
            return new ConfirmationEmail();
        }

        public static IShipping CreateDelivery()
        {
            return new Shipping(CreatePerson());
        }
    }
}
