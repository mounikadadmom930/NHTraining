using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//*****************************************************
//Author:paluru mounika
//Purpose:to print factorial of a number
//****************************************************

namespace MounikaLibrary
    {
        public class Mathmatics
        {
            int input;
            /// <summary>
            /// read data
            /// </summary>
            public void ReadData()
            {
                Console.WriteLine("enter a number");
                input = Convert.ToInt32(Console.ReadLine());

            }
            /// <summary>
            /// getfactorial
            /// </summary>
            /// <returns></returns>
            public int GetFactorial()
            {
                int Fact = 1;
                for (int i = 1; i <= input; i++)
                    Fact = Fact * i;
                return Fact;
            }
        }


        internal class Program
        {
            static void Main(string[] args)
            {
                Mathmatics math = new Mathmatics();
                math.ReadData();
                Console.WriteLine(math.GetFactorial());
                Console.ReadLine();
            }
        }
    }




