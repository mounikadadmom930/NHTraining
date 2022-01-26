using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3natural
{
    //internal class Program
    {
        static void Main(string[] args)
        {
        int input, sum = 0, i;
            Console.WriteLine("Enter any number");
            input=Convert.ToInt32(Console.ReadLine());

            for (i = 0; i <= input; i++)
                sum = sum + i;

            Console.WriteLine(sum);
            
            Console.ReadLine();
        }
    }
}
