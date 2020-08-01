using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Theory.ThreadsWithLock
{
    /// <summary>
    /// Threads - a thread is nothing more than a process.
    /// We can pass to a thread only methods without arguments and that return nothing
    /// </summary>
    public class ThreadsTheory
    {
        public void Execute()
        {
            Shop zara = new Shop(15);
            Thread[] orders = new Thread[5];

            for (int i = 0; i < 5; i++)
            {
                Thread orderFromZara = new Thread(new ThreadStart(zara.Order));
                orders[i] = orderFromZara;
            }

            for (int i = 0; i < 5; i++)
            {
                orders[i].Start();
            }

            Console.ReadLine();
        }
    }
}
