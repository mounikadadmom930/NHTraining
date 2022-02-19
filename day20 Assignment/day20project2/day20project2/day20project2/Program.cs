
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//**************************************************
//Author: paluru mounika
//Purpose: example C# code for multi cast delegate
//***************************************************
namespace project_2
{
    public delegate void MyCaller(int a, int b);
    internal class Program
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static void Mul(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        public static void Div(int a, int b)
        {
            Console.WriteLine(a / b);
        }
        static void Main(string[] args)
        {
            MyCaller mc = new MyCaller(Add);
            mc += Mul;
            mc += Div;
            // 15, 16
            mc(15, 16);
            Console.WriteLine("********************************************");
            //13,16
            mc(13, 16);
            Console.WriteLine("*********************************************");
            //14,18
            mc(14, 18);

            Console.ReadLine();
        }
    }
}

