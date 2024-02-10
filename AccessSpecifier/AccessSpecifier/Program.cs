using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifier
{
    //Case 1 : Consuming member of a class from same class of same project
    public class Program
    {
        
            public void Test1()
            {
                Console.WriteLine("Public method is called...");
            }

            private void Test2()
            {
                Console.WriteLine("Private method is called...");

            }

            protected void Test3()
            {
                Console.WriteLine("Protected method is called...");

            }
            internal void Test4()
            {
                Console.WriteLine("Internal method is called...");
            }

            protected internal void Test5()
            {
                Console.WriteLine("Protected Internal method is called...");
            }

            static void Main(string[] args)
            {
                Program p=new Program();
            
                p.Test1();
                p.Test2();
                p.Test3();
                p.Test4();
                p.Test5();

            Console.ReadLine();
        }
    }
}
