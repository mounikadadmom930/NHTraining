using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//**************************************************
//Author:paluru mounika
//Purpose: division program using exception handling
//***************************************************

namespace day12project1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int  b, c;
                Console.WriteLine("Enter a");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter b");
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
                Console.WriteLine(c);
                Console.ReadLine();

            }

            catch (OverflowException)
            {
                Console.WriteLine("the numbers between 0 t0 600000");
                Console.ReadLine();
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("cannot divide with Zero");
                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("only numbers are allowed");
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("some error occur please contact mouni@gmail.com");
                Console.ReadLine();
            }
           

        }
    }
}
