using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Theory.Threads_Multithreading
{
    /// <summary>
    /// Threads - a thread is nothing more than a process.
    /// We can pass to a thread only methods without arguments and that return nothing
    /// </summary>
    public class Threads_MultithreadingTheory
    {
        public void Execute()
        {
            Shop myShop = new Shop(15);
            Thread[] orders = new Thread[5];

            //Here we are creating 5 threads that will call our method Order
            for (int i = 0; i < 5; i++)
            {
                Thread order = new Thread(new ThreadStart(myShop.Order));
                orders[i] = order;
            }

            //Here we have our threads trying to execute
            for (int i=0; i < 5; i++)
            {
                orders[i].Start();
            }

            Console.ReadLine();
        }
    }
}
