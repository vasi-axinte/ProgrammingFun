using System;
using System.Collections.Generic;
using System.Linq;

namespace Theory.Queue  
{
    public class Recipe
    {
        public Recipe()
        {
            //Creating a queue
            Queue<string> recipeIngredients = new Queue<string>();
            //Enqueue adds elements in Queue
            recipeIngredients.Enqueue("Wine");   
            recipeIngredients.Enqueue("Water");
            recipeIngredients.Enqueue("Eggs");
            recipeIngredients.Enqueue("Bread");
            recipeIngredients.Enqueue("Flour");

            //We are accesing the elements of Recipe(our queue) using foreach loop
            foreach (var product in recipeIngredients)
            {
                //This will display our queue of elements
                Console.WriteLine(product);
            }
            Console.WriteLine();
           
            //Count returns the number of elements from the queue
            Console.WriteLine("We have {0} queue items", recipeIngredients.Count());

            // Dequeue removes the oldest element from the queue
            Console.WriteLine("We are removing {0} from our queue", recipeIngredients.Dequeue()); 
            Console.WriteLine();

            // Peek returns the element at the beginning of the queue without removing it
            Console.WriteLine("Our new first item: {0}", recipeIngredients.Peek()); 
            Console.WriteLine();

            //Contains will return TRUE if we find the element in our Queue or FALSE if it won`t find it
            Console.WriteLine("We are looking for bread:{0}", recipeIngredients.Contains("Bread"));  
            Console.WriteLine("We found bread in our queue"); 
            Console.WriteLine();

            Console.WriteLine("This is our final queue:");
            foreach (var product in recipeIngredients)
            {
                Console.WriteLine(product);
            }
            Console.ReadLine();

            //Clear is used to remove the elements from the queue
            recipeIngredients.Clear();  
        }
    }
}