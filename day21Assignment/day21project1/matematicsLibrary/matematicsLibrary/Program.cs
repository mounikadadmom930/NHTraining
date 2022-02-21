using matematicsLibrary.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matematicsLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            WebService1SoapClient obj = new WebService1SoapClient();
            Console.WriteLine(obj.Factorial(5));
            Console.WriteLine(obj.Add(5,6));
            Console.WriteLine(obj.mul(2, 3));
            Console.WriteLine(obj.sub(9, 4));
            Console.WriteLine(obj.div(4, 2));   
            Console.ReadLine();

        }
    }
}
