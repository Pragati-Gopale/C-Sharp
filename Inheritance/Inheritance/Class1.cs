using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //PARENT CLASS
    public class Class1
    {

        public Class1(int a) // 1. the default acces modifier of constructor is private (we can take public too)
                        // 2.  if we make it private then child classes can't inherit the constructor of parent class
                        // or parent class or getting error to child classes
        {
            Console.WriteLine("Parent class constructor called..."+a);
        }
        public void Test1()
        {
            Console.WriteLine("Parent method 1 called...");
        }

        public void Test2() 
        { 
            Console.WriteLine("Parent method 2 called..."); 
        }
        static void Main(string[] args)
        {
        }
    }
}
