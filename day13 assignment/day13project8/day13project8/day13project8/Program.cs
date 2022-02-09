using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//********************************************
//author:paluru mounika
//purpose:declare jagged array print the values
//*********************************************

namespace day13project8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] values = new int[3][];
            values[0] = new int[] {2,4,6 };
            values[1] = new int[] { 4,2,3,9};
            values[2] = new int[] {7,9,4,2,7 };

            for (int i = 0; i < 3; i++) 
            {
                for (int j = 0; j < values[i].Length; j++)
                {
                    Console.WriteLine(values[i][j] + " ");
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}
