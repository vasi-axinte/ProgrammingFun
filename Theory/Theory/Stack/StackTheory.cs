using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.Stack
{
    /// <summary>
    /// Stack represents a last-in-first-out ( LIFO ) collection
    /// We use stack when we want to get things out in the reverse order than we put them in
    /// </summary>
    public class StackTheory    
    {
        /// <summary>
        /// Imgine having a pillar of books, and u want to take the bottom book without
        /// destroying the pillar.So, u will have to remove the latest books that u put
        /// in the pillar to get to the bottom one.Like this, the first book added to the
        /// pillar(the bottom one) will be the last that comes out.
        /// </summary>

        public void Execute()
        {
            PillarOfBooks myBooks = new PillarOfBooks();
            myBooks.Pillar();
        }
    }
}