using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Theory.TaskAndThreads
{
    /// <summary>
    /// Tasks class lets you create tasks and run them asynchronously
    /// A task is an object that represents some work that should be done.
    /// The task can tell you if the work is completed. and if the operation 
    /// returns a result, the task gives you the result.
    /// Task are used when we want to execute something in parallel
    /// </summary>
    public class TaskTheory
    {
        /// <summary>
        /// Here we are creating 10 random tasks
        /// By using WaitAll we are waiting for all tasks to complete and only after
        /// that we will display their status
        /// If we don`t use WaitAll, some of the task won`t have their status "RanToCompletion"
        /// </summary>
        public void Execute()
        {
            Task[] commands = new Task[10];

            for(int i = 0; i < 10; i++)
            {
                commands[i] = Task.Run(() => Thread.Sleep(1000));
            }
            Task.WaitAll(commands);
            Console.WriteLine("Status of completed commands");
            foreach (var command in commands)
            {
                Console.WriteLine("Command:" + " " + command.Id + " " + command.Status);
            }

            Console.ReadLine();
        }
    }
}
