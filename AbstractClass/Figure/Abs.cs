using System;

namespace Figure
{
   public abstract class Abs
    {
        public double width, height, radius;
        public const float pi = 3.1416f;

        public abstract void getResult();
    }

    public class Rectangle : Abs  
    {
        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public override void getResult()
        {
            Console.WriteLine(width * height);
        }
    }

    public class Circle : Abs  
    {
        public Circle(int radius)
        {
            this.radius = radius;
        }

        public override void getResult()
        {
            Console.WriteLine(pi * radius * radius);
        }
    }

    public class print
    {
        public static void Main(string[] args)
        {
            Rectangle r = new Rectangle(10,25);
            Circle c = new Circle(35);
            r.getResult();
            c.getResult();
        }

    }
}
