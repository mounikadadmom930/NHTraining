using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//**************************************************
//author:paluru mounika
//purpose: program to illustrate usage of  queue
//***************************************************

namespace day13project12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> data = new Queue<int>();
            data.Enqueue(21);    
            data.Enqueue(25);    
            data.Enqueue(13); 
            Console.WriteLine(data.Count);  
            Console.WriteLine(data.Peek());  
            Console.WriteLine(data.Count);
            Console.ReadLine();

        }
    }
}
