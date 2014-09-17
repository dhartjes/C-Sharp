using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSFSDemo3
{
    interface Printable //Doesn't use access identifiers like public, private, protected or whatever. Not legal.
    {
        //All implementing classes must implement both a metohd and a property.
        void Print();
        int Status { get; }
    }
}
