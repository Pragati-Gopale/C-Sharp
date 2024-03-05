using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
   
    class Program
    {
        int i = 1; //can initialize field at the time of declaration
        public Program(int i) 
        {
            this.i = i;
        }

        

        void display()
        {
            Console.WriteLine("Method is called in class:" + i);
        }
        static void Main(string[] args)
        {
            /* Program m = new Program();  1. by using default constructor
               m.display();  
            */

            Program n =new Program(1);  //2. by using parameterized constructor
            n.display();
            

            Console.ReadLine();
        }
    }
}
