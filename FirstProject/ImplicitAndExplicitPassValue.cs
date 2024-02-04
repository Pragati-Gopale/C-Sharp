using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class ImplicitPassValue
    {
        public int x;
    }

    class ImplicitAndExplicitPassValue {
        int x;
        public ImplicitAndExplicitPassValue(int x)
        {
            this.x = x;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Implicit constructor called...and default values assign to variable");
            ImplicitPassValue S1 = new ImplicitPassValue();
            ImplicitPassValue S2 = new ImplicitPassValue();
            Console.WriteLine(S1.x+" "+S2.x);

            Console.WriteLine("Explicit constructor called...and values pass to variable...");
            ImplicitAndExplicitPassValue s1=new ImplicitAndExplicitPassValue(10);
            ImplicitAndExplicitPassValue s2 = new ImplicitAndExplicitPassValue(20);
            Console.WriteLine(s1.x+" "+s2.x);
        }
    }
    
}
