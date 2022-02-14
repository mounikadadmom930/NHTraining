using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day16project1
{
    class message
    {
        public string PrintHello()
        {
            return"Hello World";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            message m=new message();    
            Console.WriteLine(m.PrintHello());
            Console.ReadLine();
        }
    }
}
