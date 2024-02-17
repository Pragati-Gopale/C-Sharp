using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAndMethod
{
    class AbsChild : AbsParent
    {

        public override void mul(int x, int y)
        {
            Console.WriteLine(x*y);
        }

        public override void div(int x, int y)
        {
            Console.WriteLine(x / y);
        }
        static void Main(string[] args)
        {
            AbsChild c=new AbsChild();
            c.add(10, 20);
            c.sub(10, 20);
            c.mul(10, 20);
            c.div(10, 20);

            Console.WriteLine("******************");

            AbsParent p = c;  
            //reference of parent class instance using child class instance
            //cannot called pure child class methods
            p.add(10, 20);
            p.sub(10, 20);
            p.mul(10, 20);
            p.div(10, 20);

            Console.ReadLine();
        }
    }
}
