using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.Stack
{ 
    public class StackTheory    //Stack represents a last-in-first-out ( LIFO ) collection
                        /*Imagine having a pillar of books, and u want to take the bottom book without
                          destroying the pillar. So, u will have to remove the latest books that u put
                          in the pillar to get to the bottom one. Like this, the first book added to the
                          pillar ( the bottom one ) will be the last that comes out. */
    {
        public void Execute()
        {
            PillarOfBooks myBooks = new PillarOfBooks();
            myBooks.Pillar();
        }
    }
}
