﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fn, sn, sum = 0;

            fn = 50;

            Console.WriteLine("Enter First number:");
            fn = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second number:");
            sn = Convert.ToInt32(Console.ReadLine());

            sum = fn + sn;

            Console.WriteLine("sum:" + sum);
            Console.ReadLine();
        }
    }
}
