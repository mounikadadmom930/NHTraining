using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathematicLibrary;

namespace day18project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter number");
            n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Algebra.Factorial(n));
            Console.ReadLine();
        }
    }
}
