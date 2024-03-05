using System;
namespace Structure
{
    struct Structure1  //same as class
    {
        int i;  //cannot initialize field at the time of declaration

        public Structure1(int i)
        {
            this.i = i;
        }


        void display()
        {
            Console.WriteLine("Method is called in structure." + i);
        }

        static void Main(string[] args)
        {
            Structure1 a = new Structure1(); //with instance creation (default value assign to field)
            a.i = 1;
            a.display();

            Structure1 b;  //without instance creation
            b.i = 2;
            b.display();

            Structure1 c = new Structure1(3); //by using parameterized constructor 
            c.display();
            Console.ReadLine();

        }
    }
}