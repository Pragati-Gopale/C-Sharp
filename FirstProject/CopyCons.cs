using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class CopyCons
    {
        int x;

        public CopyCons(int i) //parameterized constructor
        {
            x = i;
        }

        public CopyCons(CopyCons obj) { //copy constructor
        
            x=obj.x;
        }

        public void Display()
        {
            Console.WriteLine("Value of x is : " + x);
        }

        static void Main(string[] args)
        {

            CopyCons c=new CopyCons(10);
            c.Display();
            CopyCons c1 = new CopyCons(c);  //copy constructor which takes the value of another constructor
            c1.Display();

            Console.ReadLine();
        }
    }
        
        
}
   

