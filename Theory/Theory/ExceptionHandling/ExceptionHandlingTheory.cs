using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.ExceptionHandling
{
    /// <summary>
    /// Exception handling is a mechanism to detect and hanle run-time errors in code
    ///  C# provides three keywords: try, catch and finally to implement exception
    ///  handling
    ///  Try - contains statement which can cause an exception
    ///  Catch - contains statement for handling the exception
    ///  Finally - contains any clean up code
    ///  In our example we have created our own exception called "EvenNumberException"
    ///  which will pop up a message if the number is not even.
    ///  In our second example we used an exception that is build-in C#
    /// </summary>
    public class ExceptionHandlingTheory
    {
        public void Execute()
        {
            CheckIfEven();
            DivideNumbers();
            Console.ReadLine();
        }

        public void CheckIfEven()
        {
            Console.WriteLine("Insert an even number");
            int number = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (number % 2 != 0) throw new EvenNumberException();
                else Console.WriteLine("yay, this is an even number");
            }
            catch
            {
                Console.WriteLine("Exception occured");
            }
        }

        public void DivideNumbers()
        {
            Console.WriteLine("Divide 2 numbers");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            int result;
            try
            {
                result = firstNumber / secondNumber;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You can`t divide by 0");
            }    
        }
    }
}
