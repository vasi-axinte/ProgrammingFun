using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Theory.ThreadsDeadlock
{
    /// <summary>
    /// A deadlock is a situation where an application locks up because two 
    /// or more activites are waiting for each other to finish.
    /// </summary>
    public class DeadlockTheory
    {
        Person buyer = new Person();
        Person seller = new Person();
        public void Execute()
        {
            Deal houseForSell = new Deal(seller, buyer);
            Thread firstDeal = new Thread(houseForSell.Buy);
            
            Deal moneyForHouse = new Deal(buyer, seller);
            Thread secondDeal = new Thread(moneyForHouse.Buy);

            firstDeal.Start();
            secondDeal.Start();

            firstDeal.Join();
            secondDeal.Join();

            Console.ReadLine();
        }
    }
}
