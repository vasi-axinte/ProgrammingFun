using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.ThreadsWithoutLock
{
    /// <summary>
    /// This example has no lock
    /// </summary>
    public class Shop
    {
        /// <summary>
        /// If we are not using lock, the stock might go under 0 and we can`t control
        /// the way that threads are running
        /// </summary>
        public int Stock { get; set; }

        public string Name { get; set; }

        public Shop(int stock)
        {
            Stock = stock;
        }

        public void BuyShirts(int order)
        {
            if ((Stock - order) < 0)
            {
                Console.WriteLine("we don`t have so many shirts on stock");
            }

            if (Stock >= order)
            {
                Console.WriteLine("Your order has been accepted");
                Console.WriteLine("We have removed {0} from our stock and we have {1} left", order, (Stock - order));
                Stock = Stock - order;
            }
        }

        public void Order()
        {
            BuyShirts(4);
        }
    }
}