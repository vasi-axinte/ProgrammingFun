using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.AbstractClassesVSInterfaces
{
    public interface IBooks
    {
        string Author { get; set; }

        string BookType { get; set; }
    }
}
