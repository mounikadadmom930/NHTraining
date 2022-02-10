using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//*******************************************
//Author:paluru mounika
//Purpose:prime number or not using break
//*******************************************

namespace day14project4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 7, i;
            for (i = 2; i < n; i++)
            {
                if (n % i == 0)
                    break;
            }
            if (i == n)
                Console.WriteLine("prime number");
            else
                Console.WriteLine("not a prime number");
            Console.ReadLine();
        }
    }
}
