using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//***************************************
//Author:paluru mounika
//Purpose: creation of files
//***************************************

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            File.Copy("C:\\Users\\mouni\\hh\\dotnet\\day1project1\\Day15 Assignment\\FilePrograms\\Hello", "C:\\Users\\mouni\\hh\\dotnet\\day1project1\\Day15 Assignment\\fil.copy\\Hello");
            Console.WriteLine("File created");
            Console.ReadLine();
        }
    }
}
