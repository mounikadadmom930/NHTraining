using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MounikaLibrary;

namespace day16project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mathmatics m = new Mathmatics();
            m.ReadData();
            Console.WriteLine(m.GetFactorial());
            Physics p = new Physics();
            Console.WriteLine(p.FinalVelocity(5,2,1));
            Chemistry c = new Chemistry();
            Console.WriteLine(c.Benzene());



            Console.ReadLine();
        }
    }
}
