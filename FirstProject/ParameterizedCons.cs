using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class ParameterizedCons
    {
        int x;
        public ParameterizedCons(int i) {
            x = i;
            Console.WriteLine("Parameterized Constructor : " + i);
        }
        public void Display()
        {
            Console.WriteLine("Value of x is : "+x);
        }
        static void Main(string[] args)
        {
            ParameterizedCons p=new ParameterizedCons(1);
            p.Display();
            
            Console.ReadLine();

        }
    }
}
