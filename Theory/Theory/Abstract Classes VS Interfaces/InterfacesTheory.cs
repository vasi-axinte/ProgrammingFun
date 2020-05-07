using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.Abstract_Classes_VS_Interfaces
{
    /// <summary>
    /// There are many differences between Abstract and Interfaces.
    /// Interface is not a class and we IMPLEMENT the interface, we are not inheriting the interface
    /// like we do with abstract 
    /// We use interfaces when we want to have multiple inheritances 
    /// </summary>
    public class InterfacesTheory
    {
        public void Execute()
        {
            Library myLibrary = new Library();
            Console.WriteLine("Our Library name is:" + " " +myLibrary.LibraryName);
            Console.WriteLine("Our Librarian is:" + myLibrary.Librarian);
            Console.WriteLine(myLibrary.BookType + " " + myLibrary.Author);
            myLibrary.SortBooks();

            Console.ReadLine();          
        }
    }
}
