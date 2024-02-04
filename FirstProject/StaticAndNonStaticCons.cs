using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class StaticAndNonStaticCons
    {
        int x;
        static int y;

        public StaticAndNonStaticCons(int x) {
            this.x = x;
            Console.WriteLine("Non-Static Constructer get called..");
        }

        static StaticAndNonStaticCons()
        {
            Console.WriteLine("Static Constructor get called..");
        }

        static void Main()
        {
            //The static constructor get called first then main method get called

            Console.WriteLine("Constructor get called..");
            StaticAndNonStaticCons s1=new StaticAndNonStaticCons(10);
            StaticAndNonStaticCons s2=new StaticAndNonStaticCons(20);
           

            Console.WriteLine(y); //static constructor 
            Console.WriteLine(s1.x+" "+ s2.x); //Non-static constructor
            
        }

    }
}
