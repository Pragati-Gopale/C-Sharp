using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessSpecifier;


namespace AccessSpecifier2
{
    //Case 4 : Consuming member of a class from child class of different project
    class Four : AccessSpecifier.Program //inherit the first project and main class in that project
    {
        static void Main()
        {
            Four f=new Four();
            f.Test1(); //public
            f.Test3(); //protected
            f.Test5(); //protected internal

            Console.ReadLine();
        }
    }
}
