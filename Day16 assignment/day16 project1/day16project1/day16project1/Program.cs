using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//******************************************
//Author:paluru mounika
//Purpose:print helloworld in object oriented method
//*********************************************

namespace day16project1
{
    /// <summary>
    /// methode for message
    /// </summary>
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
