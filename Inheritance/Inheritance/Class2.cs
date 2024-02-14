using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //CHILD CLASS 1
    public class Class2 : Class1 //inheriting parent class of class1 
    {

        public Class2(int a) : base(a)
        {
            Console.WriteLine("Child 2 class constructor is called...");
        }
        public void Test3() 
        {
            Console.WriteLine("Child method 1 called..");
        }
        static void Main ()
        {
            //parent class constructor is called by default
            Class2 c= new Class2(20); // creation of object class2
            c.Test1(); //call method of class1 i.e. parent class
            c.Test2(); // call method of class1 i.e. parent class
            c.Test3(); //call method of class2 i.e. child class
            
            Console.ReadLine ();
        }
    }
}
