using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        int x; //non-static variable
        static int y = 10; // static variable
        const int z = 20;  //constant variable
        readonly int a ;  //readonly variable
                          //(we can initialized "readonly varibale" by using constructor, instance of the class, directly assigning the value

        public Program(int x, int a)
        {
            this.x = x;
            this.a= a;
            
            
        }

        

        static void Main(string[] args)
        {
            Console.WriteLine(y); //static 
            Console.WriteLine(z);  //constant
           // (both static and constant variables doesn't require instance of class to executed and initialization)



            Program p=new Program(30, 40);
            Program p1=new Program(50,60);
            Console.WriteLine(p.x); //non-static  
            Console.WriteLine(p.a); //readonly
            // (both non-static and readonly variables requires instance of class(or via constructor) to executed and initialization)

            Console.ReadLine();
        }
    }
}
