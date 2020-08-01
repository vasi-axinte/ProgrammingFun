using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Theory.ThreadsWithoutLock
{
    public class ThreadsTheory
    {
        public void Execute()
        {
            Shop bershka = new Shop(15);
            Thread[] orders = new Thread[5];

            for (int i = 0; i < 5; i++)
            {
                Thread orderFromBershka = new Thread(new ThreadStart(bershka.Order));
                orders[i] = orderFromBershka;
            }

            for (int i = 0; i < 5; i++)
            {
                orders[i].Start();
            }

            Console.ReadLine();
        }
    }
}
