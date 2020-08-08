using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace Theory.Threadpool
{
    /// <summary>
    /// Thread pooling is the process of creating a collection of threads
    /// and then reusing those threads for new tasks as and when required, instead
    /// of creating new threads.
    /// </summary>
    public class ThreadpoolTheory
    {
        public void Execute()
        {
            Stopwatch tournamentWatch = new Stopwatch();

            Console.WriteLine("The timer has started");
            tournamentWatch.Start();
            StartFirstStrategy();
            tournamentWatch.Stop();
            Console.WriteLine("Time consumed by first strategy:" + tournamentWatch.ElapsedTicks.ToString());

            tournamentWatch.Reset();

            Console.WriteLine("The timer has started");
            tournamentWatch.Start();
            StartSecondStrategy();
            tournamentWatch.Stop();
            Console.WriteLine("Time consumed by second strategy:" + tournamentWatch.ElapsedTicks.ToString());

            Console.ReadLine();

        }
  
        public void StartFirstStrategy()
        {
            for ( int i = 1; i < 9; i++)
            {
                Thread start = new Thread(PlanningAttack);
            }
        }

        public void StartSecondStrategy()
        {
            for (int i = 1; i < 9; i++)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(PlanningAttack));
            }
        }

        public void PlanningAttack(object time)
        {
        }
    }
}
