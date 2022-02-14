using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//********************************************
//Author:paluru mounika
//Purpose: creation of files
//************************************************
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // File.Create("C:\\Users\\mouni\\hh\\dotnet\\day1project1\\Day15 Assignment\\FilePrograms\\Hello.text");
             //Console.WriteLine("file created");
            // Console.ReadLine();
            //File.WriteAllText("C:\\Users\\mouni\\hh\\dotnet\\day1project1\\Day15 Assignment\\FilePrograms\\Hello.text", "Hello world");
            //Console.WriteLine("file created");
            //Console.ReadLine();
            File.Copy("C:\\Users\\mouni\\hh\\dotnet\\day1project1\\Day15 Assignment\\FilePrograms\\Hello", "C: \\Users\\mouni\\hh\\dotnet\\day1project1\\Day15 Assignment\\FilePrograms\\file.copy\\Hello");
            Console.WriteLine("File created");
            Console.ReadLine();
        }
    }
}
 