using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.Abstract_Classes_VS_Interfaces
{
    /// <summary>
    /// One class can implement from multiple interfaces, but if we use abstract calsses
    /// it can inherit from only one parent.
    /// </summary>
    public class Library : ILibrary, IBooks
    {  
        public Library()
        {
            this.LibraryName = "Royal";
            this.Librarian = "Tyler";
            this.BookType = "In our stock we have all types of books";
            this.Author = "In our stock we have almost all authors in the world";
        }

       public string LibraryName { get; set; }

       public string Librarian { get; set; }

       public string Author { get; set; }

       public string BookType { get; set; }

        public void SortBooks()
        {
            Console.WriteLine("We are sorting books by Author...");
        }
    }
}
