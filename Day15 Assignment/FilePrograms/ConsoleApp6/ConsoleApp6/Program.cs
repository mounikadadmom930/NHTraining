using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourceFile = @"C:\Users\mouni\hh\dotnet\day1project1\Day15 Assignment\FilePrograms\\Hello";
            string destination = @"C:\Users\mouni\hh\dotnet\day1project1\Day15 Assignment\move.file\\Hello";
            File.Move(sourceFile, destination);
            Console.WriteLine("file moved");
           
            Console.ReadLine();

        }
    }
}
