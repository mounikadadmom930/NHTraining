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
        public int sub(int a, int b)
        {
            return a - b;
        }
    }
    class TotalMaths : Algebra
    {
        public int mul(int a, int b)
        {
            return (a * b);
        }
    }
    class Allsubjects : TotalMaths
    {
        public string methane()
        {
            return "CH4";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Allsubjects obj = new Allsubjects();
            Console.WriteLine(obj.add(10, 5));
            Console.WriteLine(obj.sub(11, 5));
            Console.WriteLine(obj.mul(12, 6));
            Console.WriteLine(obj.methane());
            Console.ReadLine();
            ;
        }
    }
}

