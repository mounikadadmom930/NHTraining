using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//*************************************
//AUTHOR:PALURU MOUNIKA
//PUPOSE:TO CREAT A MATHMATICS CLASS AND ADD 3 STATIC METHODES
//*****************************************

namespace day11project4
{
    class Mathematics
    { 
        /// <summary>
        /// Addition
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int Add(int a, int b)
        {
            return a + b;
        }
        /// <summary>
        /// subtraction
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int Sub(int a, int b)
        {
            return a - b;
        }
        /// <summary>
        /// multiplication
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int Mul(int a, int b)
        {
            return (a * b);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Mathematics.Add(3, 6));
            Console.WriteLine(Mathematics.Sub(7, 5));
            Console.WriteLine(Mathematics.Mul(4, 2));

            Console.ReadLine();
        }
    }
}
