using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.SealedClass
{
    public class SealedTheory
    {
        public void Execute()
        {
            Worker cristi = new Worker();
            cristi.StartWorking();

            Manager vasi = new Manager();
            vasi.StartWorking();
            vasi.FireWorker();

            Console.ReadLine();
        }
    }
}
