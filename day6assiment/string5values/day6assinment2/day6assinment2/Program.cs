using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6assinment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> data = new List<string>();
            data.Add("mounika");
            data.Add("pavani");
            data.Add("madavi");
            data.Add("manju");
            data.Add("latha");

            for(int i=0;i<data.Count;i++)
            {
                Console.WriteLine(data[i]); 
            }
           //foreach loop
           foreach(var d in data)
                Console.WriteLine(d);

           //lamda
           data.ForEach(p=>Console.WriteLine(p));
            Console.ReadLine();
           
        }
    }
}
