using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    //1.The concept of method overloading comes under the polymorphism.
    //2. Polymorphism means it's a mechanism of changing the behaviour of methods based on inputs.
    //i.e. when inputs changes automatically the behaviour of output changes.
    //3. Method Overloading means It's an approach of defining a method with multiple bahaviours.
    //Where the behaviours of method will change based on inputs such as:
    //  1.Number of parameter  2. Type of parameter  3. Order of parameter

    public class Program
    {
        public void Test () 
        {
            Console.WriteLine("1st method called...");
        }
        public void Test(int i)
        {
            Console.WriteLine("2nd method called...");
        }
        public void Test(string s)
        {
            Console.WriteLine("3rd method called...");
        }
        public void Test(int i, string s)
        {
            Console.WriteLine("4th method called...");
        }
        public void Test(string s, int i)
        {
            Console.WriteLine("5th method called...");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Test();
            p.Test(10);
            p.Test("Hello Cutie!");
            p.Test(20, "How are you?");
            p.Test("Bye...", 30);

            Console.ReadLine();
        }
    }
}
