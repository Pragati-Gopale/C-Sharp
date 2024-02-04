using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class DefaultCons
    {
        int i; bool b;
        static void Main(string[] args)
        {
            DefaultCons p = new DefaultCons();
            Console.WriteLine("Value of i is : "+p.i);
            Console.WriteLine("Value of b is : " + p.b);

            Console.ReadLine();
        }
    }
}
