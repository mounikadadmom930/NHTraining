using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//**************************************
//Author:paluru mounika
//purpose:creation of files
//**************************************

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter Sr = new StreamWriter("C:\\Users\\mouni\\hh\\dotnet\\day1project1\\Day15 Assignment\\FilePrograms\\Hello",true);
            Sr.WriteLine("HI");
            Sr.WriteLine("i am ");
            Sr.WriteLine("Lerning");
            Sr.WriteLine("c#");
            Sr.Close();
            Console.WriteLine("File done");
            Console.ReadLine();
        }
    }
}
