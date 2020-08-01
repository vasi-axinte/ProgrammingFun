using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Theory.ThreadsDeadlock
{
    /// <summary>
    /// Here we have 2 threads Thread1 (houseForSell) and Thread2 (moneForHouse)
    /// We are making a deal, we have one seller who is selling a house, and a
    /// buyer who want to buy that house
    /// We are calling the Buy method on thread1, that will acquire lock on Seller, 
    /// after that, thread1 will sleep for 1 sec, and at the same time thread2 will
    /// run and will acquire lock on Buyer, and after that thread2 is going to sleep
    /// too. Now, when both threads are waking up the deadlock has been achieved 
    /// because thread1 is trying to acquire lock on Buyer, and thread2 is trying to 
    /// acquire lock on Seller
    /// </summary>
    public class Deal
    {
       public Person Seller;
       public Person Buyer;

        public Deal(Person seller, Person buyer)
        {
            Seller = seller;
            Buyer = buyer;
        }

        public void Buy()
        {
            lock(Seller)
            {
                Thread.Sleep(1000);
                lock(Buyer)
                {
                    Console.WriteLine("Deal acomplished");
                }
            }
        }
    }
}
