using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string curFile = @"C:\Users\mouni\hh\dotnet\day1project1\Day15 Assignment\FilePrograms\\Hello";
           
            Console.WriteLine(File.Exists("C:\\Users\\mouni\\hh\\dotnet\\day1project1\\Day15 Assignment\\FilePrograms\\Hello") ? "File exits" : "File deos not exits") ;
               
            
            Console.ReadLine();
        }
    }
}
