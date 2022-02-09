using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//*****************************************
//author: paluru mounika
//purpose:intializing the value in same linle using nested forloop print arrays
//***********************************************

namespace day13project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] data = new int [3,2]{ { 23, 34 }, { 42, 25 }, { 46,75} };
            
            for (int i = 0; i < 3; i++) 
            {
                
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(data[i, j] + " ");
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}
