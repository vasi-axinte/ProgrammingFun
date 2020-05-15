using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.Abstract_Classes_VS_Interfaces
{
    /// <summary>
    /// Interface accept public modifier, abstract accept all access modifier
    /// If we are adding a new method in our Interface, we need to find all the 
    /// classes that implements that interfaces and add that method there too
    /// </summary>
    public interface ILibrary
    {
        string LibraryName { get; set; }

        string Librarian { get; set; }

        /// <summary>
        /// Interfaces only need to have just the method definition, without the body
        /// Abstract cand have both of them, the method definition and complete definition
        /// </summary>
        void SortBooks();
    }
}
