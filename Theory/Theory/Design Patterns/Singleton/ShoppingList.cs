using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.Design_Patterns.Singleton
{
    public class ShoppingList
    {
        private static string title = "Shopping List:";
        private static ShoppingList instance = null;
        /// <summary>
        /// This method checks if our class has an instance, and if not, it will 
        /// create an instance
        /// </summary>
        public static ShoppingList Instance
        {
            get
            {
                if (instance == null)
                    instance = new ShoppingList();
                return instance;
            }
        }

        private ShoppingList()
        {
            Console.WriteLine(title);
        }

        public void AddProduct(string product)
        {
            Console.WriteLine(product);
        }
    }
}
