using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces_circle_square_rectangle_triangle
{

    interface IShape
    {
        int CalculatePerimeter();
        int CalculateArea();
    }
    class Circle : IShape
    {
        private int radius;
        public void ReadRadius()
        {
            Console.WriteLine("Enter radius:");
            radius = Convert.ToInt32(Console.ReadLine());
        }
        public int CalculateArea()
        {
            return 22 * radius * radius / 7;
        }

        public int CalculatePerimeter()
        {
            return 2 * 22 * radius / 7;
        }
    }
    class Square : IShape
    {
        private int side;
        public void ReadSide()
        {
            Console.WriteLine("Enter side:");
            side = Convert.ToInt32(Console.ReadLine());
        }
        public int CalculateArea()
        {
            return side * side;
        }

        public int CalculatePerimeter()
        {
            return 4 * side;
        }
    }
    class Rectangle : IShape
    {
        private int length;
        public void ReadLength()
        {
            Console.WriteLine("Enter length:");
            length = Convert.ToInt32(Console.ReadLine());
        }
        private int width;
        public void ReadWidth()
        {
            Console.WriteLine("Enter width:");
            width = Convert.ToInt32(Console.ReadLine());
        }
        public int CalculateArea()
        {
            return length * width;
        }

        public int CalculatePerimeter()
        {
            return 2 * (length + width);
        }
    }
    class Triangle : IShape
    {
        private int Side1;
        public void ReadSide1()
        {
            Console.WriteLine("Enter side 1");
            Side1 = Convert.ToInt32(Console.ReadLine());
        }
        private int Side2;  
        public void ReadSide2()
        {
            Console.WriteLine("Enter side2");
            Side2 = Convert.ToInt32(Console.ReadLine());
        }
        private int side3;

        public void Readside3()
        {
            Console.WriteLine("Enter side3");
            side3 = Convert.ToInt32(Console.ReadLine());
        }

        public int CalculateArea()
        {
            float s = (Side1 + Side2 + side3) / 2;
            int Area=(int)Math.Sqrt((s * (s - Side1) * (s - Side2) * (s - side3)));
            return Area;
        }

        public int CalculatePerimeter()
        {
            return Side1 + Side2 + side3;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            c.ReadRadius();
            Console.WriteLine(c.CalculatePerimeter());
            Console.WriteLine(c.CalculateArea());


            Square s = new Square();
            s.ReadSide();
            Console.WriteLine(s.CalculatePerimeter());
            Console.WriteLine(s.CalculateArea());

            Rectangle r = new Rectangle();
            r.ReadLength();
            r.ReadWidth();
            Console.WriteLine(r.CalculatePerimeter());
            Console.WriteLine(r.CalculateArea());

            Triangle t = new Triangle();
            t.ReadSide1();
            t.ReadSide2();
            t.Readside3();
            Console.WriteLine(t.CalculatePerimeter());
            Console.WriteLine(t.CalculateArea());
            Console.ReadLine();
        }
    }
}
