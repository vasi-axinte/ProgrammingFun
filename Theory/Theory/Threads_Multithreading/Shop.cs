using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Theory.Threads_Multithreading
{
    public class Shop
    {
        /// <summary>
        /// We are using this object to lock the Stock, so the stock wont go under 0
        /// </summary>
        private Object stockLock = new Object();
        int Stock { get; set; }

        string Name { get; set; }

        public Shop(int stock)
        {
            Stock = stock;
        }

        /// <summary>
        /// Lock keeps other threads from entering a statement block untill 
        /// another thread leaves
        /// </summary>
        public void BuyShirts(int order)
        {
            if ((Stock - order) < 0)
            {
                Console.WriteLine("we don`t have so many shirts on stock");
            }

         //   lock (stockLock)
           // {
                if(Stock >= order)
                {
                    Console.WriteLine("Your order has been accepted");
                    Console.WriteLine("We have removed {0} from our stock and we have {1} left", order, (Stock-order));
                    Stock = Stock - order;
                }
           // }       
        }

        public void Order()
        {
            BuyShirts(4);
        }
      
    }
}
