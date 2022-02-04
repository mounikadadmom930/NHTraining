using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day10_project
{
    class Algebra
    {
        public int add(int a, int b)
        {
            return a + b;
        }
        public int add(int a, int b,int c)
        {
            return a + b +c;
        }
        public int add(int a,int b,int c,int d)
        {
            return a + b + c + d;
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Algebra obj = new Algebra();
            Console.WriteLine(obj.add(9, 9));
            Console.WriteLine(obj.add(8, 3,6));
            Console.WriteLine(obj.add(7,6, 8,9));

            Console.ReadLine();
            ;
        }
    }
}



