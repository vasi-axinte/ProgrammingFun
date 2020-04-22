using System;
using System.Collections.Generic;
using System.Linq;

namespace Theory.Queue  
{
    public class ShoppingList
    {
        public void List()
        {
            Queue<string> myShoppingList = new Queue<string>();
            myShoppingList.Enqueue("Wine");   //Enqueue adds an element to the end of the Queue
            myShoppingList.Enqueue("Water");
            myShoppingList.Enqueue("Eggs");
            myShoppingList.Enqueue("Bread");
            myShoppingList.Enqueue("Coke");

            Console.WriteLine("This is our queue:");
            foreach (var product in myShoppingList)
            {
                Console.WriteLine(product);  //This is our queue of elements
            }
            Console.WriteLine();
            Console.WriteLine("We have {0} queue items ", myShoppingList.Count()); //Count returns the number of elements from the queue


            Console.WriteLine("We are removing {0} from our queue", myShoppingList.Dequeue()); // Dequeue removes the oldest element from the queue
            Console.WriteLine();

            //now we have a new first element in our queue
            Console.WriteLine("Our new first item: {0}", myShoppingList.Peek()); // Peek returns the element at the beginning of the queue
            Console.WriteLine();

            //now we want to look through the queue for a specific object 
            Console.WriteLine("We are looking for bread: {0}", myShoppingList.Contains("Bread"));  //This will return TRUE if we find the element in or list or FALSE if we won`t find it
            Console.WriteLine("We found bread in our queue");
          
            Console.WriteLine();
            Console.WriteLine("This is our final queue:");
            foreach (var product in myShoppingList)
            {
                Console.WriteLine(product);
            }
            Console.ReadLine();

            myShoppingList.Clear();  //With Clear we are removing all elements from our queue
        }
        
    }
}