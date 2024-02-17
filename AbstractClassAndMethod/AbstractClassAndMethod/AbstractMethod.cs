using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAndMethod
{
    public abstract class AbstractMethod
    {
        public double height, width, radius;
        public const float pi = 3.14f;

        public abstract double GetArea();
    }
    public class Rectangle : AbstractMethod
    {
        public Rectangle(double height, double width) 
        {
          this.height = height;
          this.width = width;


        }
        public override double GetArea() 
        {
            return height * width;
        }

    }

    public class Circle : AbstractMethod
    {  public Circle(double radius) 
        {
            this.radius = radius;
        } 
    public override double GetArea() 
        { 
        return radius * radius * pi;
        }
    }

    public class Cone : AbstractMethod
    { 
        public Cone(double radius, double height) 
        {
            this.radius = radius;
            this.height= height;
        } 

        public override double GetArea()
        {
            return pi * radius * (radius + Math.Sqrt(height * height + radius*radius));
        }
    }

    public class AbstractMethod1
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(1.2, 3.4);
            Circle c = new Circle(10.0);
            Cone cn = new Cone(10.0, 2.3);

            Console.WriteLine("Area of rectangle : "+r.GetArea());
            Console.WriteLine("Area of circle : "+c.GetArea());
            Console.WriteLine("Area of cone : "+cn.GetArea());

            Console.ReadLine();
        }
    }
}
