using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//********************************************
//author:paluru mounika
//purpose: sum of two matrices
//***************************************************

namespace Day13Project5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] a1 = new int[2, 2];

            Console.WriteLine("Enter First Matrix:");
            //Read values for arr1 from user

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                   
                    a1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int[,] a2 = new int[2, 2];
            Console.WriteLine(" Enter Second Matrix:");
            //Read values for arr1 from user

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                 
                    a2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // adding two matrixes
            Console.WriteLine("addition of two matrices");
            int[,] a3 = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    a3[i, j] = a1[i, j] + a2[i, j];

                }

            }

            // printing matrix
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(a3[i, j] + " ");
                }
                Console.Write("\n \n");

            }
            Console.ReadLine();

        }
    }
}
