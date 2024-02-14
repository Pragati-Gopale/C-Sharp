using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //CHILD CLASS 2
    public class Class3 : Class1
    {

        public Class3() : base(10) //public Class3(int a) : base(a)
        {
            Console.WriteLine("Child 2 class constructor is called...");
        }

        // parent class constructor is parameterized then the child class can't implicitely call the parenbt class constructor,
        // to overcome this we have to call it explicetly by using "base" keyword
        //pass the value in the base keyword like base(10)
        // or second way is by passing the argument to base keyword which we provide to child class constrcutor,and call parent class constrcutor
        //like - public Class3(int a) : base(a)
        //we will get a value of parent class constrcutor, which we have been provide it to the child class constructor
        static void Main(string[] args)
        {
            Class1 p; //reference of parent class
            Class3 c1= new Class3();
            p = c1; // initialize the reference variable by using instance of child class (p takes the memory of c1)
            p.Test1();
            p.Test2();
           
            

            // 1. by default parent class constructor is alos get called
            // 2. child class get all properties of parent class but parent class can't get all properties of child class,
            //That's why parent class object can't call child class constructor.
           
            
            
            Console.ReadLine();
        }
    }
}
