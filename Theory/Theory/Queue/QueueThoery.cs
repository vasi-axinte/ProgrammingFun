using System;

/// <summary>
/// Queue represents a first-in, first-out collection.
/// We use Queue when we want to get things out in the order that we put them in
/// Imagine going at McDonalds drive. If you are the first in line, you will get out first
/// </summary>
namespace Theory.Queue  
{          
    public class QueueThoery
    {
        public void Execute()
        {
            Recipe queue = new Recipe();
            Console.WriteLine(queue);             
        }
    }
}