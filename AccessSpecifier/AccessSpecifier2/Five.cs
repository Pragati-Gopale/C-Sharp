using AccessSpecifier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifier2
{
    //Case 5 : Consuming member of a class from non-child class of different project
    public class Five
    {

        static void Main(string[] arg)
        {
            AccessSpecifier.Program p = new AccessSpecifier.Program();  //object creation of main class or first class(in this class we inherit the parent class(main class) of first project)
            p.Test1(); //public
             
            Console.ReadLine();
            
        }
    }
}
