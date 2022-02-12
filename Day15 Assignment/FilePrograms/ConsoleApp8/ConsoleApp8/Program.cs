using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("C:\\Users\\mouni\\hh\\dotnet\\day1project1\\Day15 Assignment\\quiz pplication");
            int score = 0, ans;
            string name;
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();
            Console.WriteLine("******************");
            Console.WriteLine("Hi{0},Welcome to quiz by mounika", name);
            Console.WriteLine("******************");
            sw.WriteLine(name);
            Console.WriteLine("Q1.fill in the blank p_r_nt:");
            Console.WriteLine("1.a,e  2.e,e  3.r,e  4.n,e");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 1)
                score += 20;

            Console.WriteLine("Q2.Who is our CM");
            Console.WriteLine("1.kcr   2.narendramodi  3.tagur   4.jagan");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 4)
                score += 20;


            Console.WriteLine("Q3.Who is the founder of NB:");
            Console.WriteLine("1.Glenn Parker  2.Michel Parker 5  3.Glenn M Parker  4.Glenn M");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 3)
                score += 20;

            Console.WriteLine("Q4.What is the fullform of OTC:");
            Console.WriteLine("1.On The Company  2.Over The Counter  3.Over The Company  4.On The Count");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 2)
                score += 20;


            Console.WriteLine("Q5.Where is the headquarters of NB");
            Console.WriteLine("1.Florida  2.France  3.America  4.India");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 1)
                score += 20;
            sw.WriteLine(score);
            sw.Close();
            Console.WriteLine("******************");
            Console.WriteLine("Thank you for taking test, Admin will inform your result");
                       

           Console.ReadLine();



        }
    }
}