using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//******************************
//author:paluru mounika
//pupose:intiliaze the array print trace of array
//*******************************

namespace day13_project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] data = new int[3, 3] { { 34, 23, 45 }, { 44, 87, 94 }, { 34, 23, 56 } };
            int sum = 0;
            for (int i = 0; i < 3; i++) 
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == j)
                        sum = sum + data[i, j];
                }

                Console.WriteLine("\n");
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
        
    }
}
