using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class DefaultCons1
    {
        int i;
        String s;
        bool b;

        public DefaultCons1(int i, String s, bool b)
        {
            Console.WriteLine("Constructor is called...");
            this.i = i;
            this.s = s;
            this.b = b;

        }


        static void Main(string[] args)
        {
            DefaultCons1 p1 = new DefaultCons1(1, "pragati", true);
            //Program1 p2 = new Program1();
            //Program1 p3 = new Program1();
            Console.WriteLine(p1.i);
            Console.WriteLine(p1.s);
            Console.WriteLine(p1.b);
            Console.ReadLine();

        }
    }
}
