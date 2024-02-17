using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAndMethod
{
    abstract class AbsParent
    {
        public void add(int x, int y) 
        {
            Console.WriteLine(x + y);
        }
        public void sub(int x, int y)
        {
            Console.WriteLine(x - y);
        }
        public abstract void mul(int x, int y);

        public abstract void div(int x, int y);      
    }
}
