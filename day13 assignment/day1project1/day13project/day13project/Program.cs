using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//***********************************************
//author:paluru mounika
//purpose:2-d array of size[2,2] print values using nested forloop
//****************************************************

namespace day13project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] data = new int[2, 2] { { 4, 5 }, { 6, 7 } };
            for(int i=0;i<2;i++)
            {
                for(int j=0;j<2;j++)
                {
                    Console.Write(data[i,j] + " ");

                }
                Console.WriteLine("\n");    

            }
            Console.ReadLine();
    
        }
    }
}
