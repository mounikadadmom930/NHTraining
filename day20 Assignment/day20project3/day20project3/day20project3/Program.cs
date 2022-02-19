

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//*************************************************************
//Author: paluru mounika
//Purpose: WACP to illustrate nullable type
//*************************************************************

namespace project_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte? input = 10;
            if (input.HasValue)
                Console.WriteLine(input * input);
            else
                Console.WriteLine("No vaiue");
            Console.ReadLine();
        }
    }
}
