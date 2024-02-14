using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Person
    {
        int id = 1;
        String name = "Pragati";
        String address = "Pune";
        long pNo = 7666765687;

        

        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine(" id : "+person.id + " Name : " + person.name + " Address : " + person.address+ " phone number : " + person.pNo);
            Student student = new Student();
            Console.WriteLine("Class : " + student.Class + " Marks : " + student.marks + " Fees : " + student.fees);
            Staff s= new Staff();
            Console.WriteLine("Designation : "+s.designation +" Salary : "+s.salary);
            TeachingStaff t=new TeachingStaff();
            Console.WriteLine("Qualification : " + t.qualification + " Subject : " + t.subject);
            NonTeachingStaff t1 =new NonTeachingStaff();
            Console.WriteLine("Department Name : " + t1.DpartName);


            Console.ReadLine();
        }
    }
    class Student : Person
    {
        public int Class = 12;
       public int marks = 50;
        public float fees = 30.00f;
    }

    class Staff : Person
    {
        public String designation = "School";
        public double salary =50.00;
    }

    class TeachingStaff : Staff
    {
       public String qualification = "D.Ed";
        public String subject = "C-Sharp";
        
    }
    class NonTeachingStaff : Staff
    {
       public String DpartName ="Account";

    }

}
