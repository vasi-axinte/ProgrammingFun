using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.RecursiveFunction
{
    /// <summary>
    /// A recursive function is a function that calls itself
    /// Here we have 2 recursive functions, a function that is calculating the
    /// factorial of our number, and another one that is displays the Nth element
    /// from fibonacci series
    /// </summary>
    public class RecursiveTheory
    {
        public void Execute()
        {
            Console.WriteLine("insert a number");
            int number = Convert.ToInt32(Console.ReadLine());

            int factorial = DoFactorial(number);
            Console.WriteLine("Factorial:" + factorial.ToString());

            int fibonacci = DoFibonacci(number);
            Console.WriteLine("Fibonacci:" + fibonacci.ToString());
       
            Console.ReadLine();
        }

        public int DoFactorial(int number)
        {
            if (number == 0)
                return 1;
            return number * DoFactorial(number - 1);
        }

        public int DoFibonacci(int number)
        {
            if ((number == 0) || (number == 1))
                return number;
            return DoFibonacci(number - 1) + DoFibonacci(number - 2);
        }
    }
}
