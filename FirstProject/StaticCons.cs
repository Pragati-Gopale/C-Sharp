using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class StaticCons
    {
        static int i;
        
        static void Main()
        {
             Console.WriteLine("Static constructor is executed.."+i);
            //static constructor is get called by default (i.e. implicitely) or we can define it explicitely also.
        }
    }
}
