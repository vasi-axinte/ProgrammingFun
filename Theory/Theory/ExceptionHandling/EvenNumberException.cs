using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.ExceptionHandling
{
    public class EvenNumberException : Exception
    {
        public EvenNumberException()
        {
               Console.WriteLine("This is not an even number!");    
        }
    }
}
