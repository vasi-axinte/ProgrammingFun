using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.SealedClass
{
    /// <summary>
    /// Sealed classes are used to restrict the inheritance feature, the class that
    /// is declared sealed can`t be used as a base class;
    /// As u can see, we defined our Manager class as sealed so, Woker class
    /// can`t inherit from Manager.
    /// </summary>
    public sealed class Manager : Worker
    {
        public void FireWorker()
        {
            Console.WriteLine("I can fire u!");
        }
    }
}
