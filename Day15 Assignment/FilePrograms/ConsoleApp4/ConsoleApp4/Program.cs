using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//*********************************************
//Author:paluru mounika
//Purpose:creation of files
//************************************************

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(File.GetLastWriteTime("C:\\Users\\mouni\\hh\\dotnet\\day1project1\\Day15 Assignment\\FilePrograms"));
            Console.ReadLine();      
        }
    }
}
