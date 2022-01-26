using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score = 0, ans;
            string name;
            Console.WriteLine("Enter your name");
            name=Console.ReadLine();
            Console.WriteLine("***************************************");
            Console.WriteLine("Hi{0},Welcome to quiz by mounika", name);
            Console.WriteLine("***************************************");

            Console.WriteLine("Q1.when is the world down syndrom day observe:");
            Console.WriteLine("1.mar 1  2.mar 10  3.mar 15  4.mar 21");
            ans=Convert.ToInt32(Console.ReadLine());
            if (ans == 3)
                score += 20;

            Console.WriteLine("Q2.earth hours day is celbrated in last saturday of which month;");
            Console.WriteLine("1.mar   2.apr  3.nov   4.dec");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 1)
                score += 20;


            Console.WriteLine("Q3.when is the international day of coscince:");
            Console.WriteLine("1.mar 1  2.aprl 5  3.mar 15  4.mar 21");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 2)
                score += 20;

            Console.WriteLine("Q4.when is the nation voters day observe:");
            Console.WriteLine("1.mar 1  2.mar 10  3.mar 15  4.jan 25");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 4)
                score += 20;


            Console.WriteLine("Q5.when is the environment day observe");
            Console.WriteLine("1.jun 5  2.mar 10  3.mar 15  4.mar 21");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 1)
                score += 20;

            Console.ReadLine();


        }
    }
}
