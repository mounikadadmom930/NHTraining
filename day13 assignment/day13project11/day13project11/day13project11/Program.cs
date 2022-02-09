using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//***************************************************
//author:paluru mounika
//purpose:program to illustrate the usage of stack<>
//***************************************************

namespace day13project11
{
    internal class Program
    {
        static void Main(string[] args)
        {
         Stack<int> data = new Stack<int>();
            data.Push(13);
            data.Push(21);
            data.Push(17);
            Console.WriteLine(data.Count);
            Console.WriteLine(data.Peek());  
            Console.WriteLine(data.Count);
            Console.ReadLine();
        }
    }
}
