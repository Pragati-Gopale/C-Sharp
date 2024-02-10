using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifier
{
    //Case 2 : Consuming member of a class from child class of same project
    public class Two : Program  // we uses " : " to inherit the parent class or another class
    {
        static void Main(string[] args)
        {
            Two t = new Two();
            t.Test1(); //public
            t.Test3(); //protected
            t.Test4(); //internal
            t.Test5(); //protected internal

            Console.ReadLine();

        }
    }
}
