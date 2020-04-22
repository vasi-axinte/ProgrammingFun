using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.Stack
{
    public class PillarOfBooks    
    {
         public void Pillar()
        {
            Stack<string> books = new Stack<string>();
            books.Push("book1");  // with push we are adding elements to our stack
            books.Push("book2");
            books.Push("book3");
            books.Push("book4");
            books.Push("book5");

            foreach(var book in books)
            {
                Console.WriteLine(book);
            }
            Console.WriteLine();

            Console.WriteLine("We have {0} book in our pillar ", books.Count()); // Count returns the number of elements from our stack
            Console.WriteLine();

            Console.WriteLine("The book from the top of the pillar is {0} ", books.Peek()); // Peek returns the element that is at the top of the stack
            Console.WriteLine();

            Console.WriteLine("We want to take the book3 from our pillar, but we don`t want the pillar to fall " + "\n" +
                "so, we will take down each book at a time");
            Console.WriteLine();

            Console.WriteLine("We are removing {0} from the pillar", books.Pop()); // Pop removes and returns the element that is at the top of the stack  ( we are removing book 5)
            Console.WriteLine("we are removing {0} from the pillar", books.Pop());  //removing book 4
            Console.WriteLine("Now we are at the book that we wanted: {0} ",books.Peek()); 
            Console.ReadLine();



        }
    }
}
