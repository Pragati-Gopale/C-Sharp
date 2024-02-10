using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifier
{
    //Case 3 : Consuming member of a class from non-child class of same project
    public class Three
    {

        static void Main(string[] args)
        {
            Program p = new Program(); //object creation of original class or main class
            p.Test1(); //public
            p.Test4(); //internal
            p.Test5(); //protected internal

            Console.ReadLine();
        }
    }
}
