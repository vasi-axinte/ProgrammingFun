using System;
using System.Collections.Generic;
using System.Linq;

namespace Theory.Queue  
{
    public class Recipe
    {
        public Recipe()
        {
            Queue<string> Recipe = new Queue<string>(); //Creating a queue
            Recipe.Enqueue("Wine");   //Enqueue adds elements in Queue
            Recipe.Enqueue("Water");
            Recipe.Enqueue("Eggs");
            Recipe.Enqueue("Bread");
            Recipe.Enqueue("Flour");

            Console.WriteLine("This is our queue:");
            foreach (var product in Recipe)   //We are accesing the elements of Recipe(our queue) using foreach loop
            {
                Console.WriteLine(product);  //This is our queue of elements
            }
            Console.WriteLine();
            Console.WriteLine("We have {0} queue items", Recipe.Count()); //Count returns the number of elements from the queue


            Console.WriteLine("We are removing {0} from our queue", Recipe.Dequeue()); // Dequeue removes the oldest element from the queue
            Console.WriteLine();

            //now we have a new first element in our queue
            Console.WriteLine("Our new first item: {0}", Recipe.Peek()); // Peek returns the element at the beginning of the queue without removing it
            Console.WriteLine();

            //now we want to look through the queue for a specific object 
            Console.WriteLine("We are looking for bread:{0}", Recipe.Contains("Bread"));  //This will return TRUE if we find the element in our Queue or FALSE if it won`t find it
            Console.WriteLine("We found bread in our queue");
          
            Console.WriteLine();
            Console.WriteLine("This is our final queue:");
            foreach (var product in Recipe)
            {
                Console.WriteLine(product);
            }
            Console.ReadLine();

            Recipe.Clear();  //Clear is used to remove the elements from the queue
        }
        
    }
}