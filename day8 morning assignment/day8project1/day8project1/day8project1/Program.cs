 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//*******************************************************************
//AUTHOR:PALURU MOUNIKA
//PURPOSE:INTIALIZE 8 VALUES TO PRINT EVEN NUMBERS
//*******************************************************************

namespace day8project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int>() { 45, 24, 46, 75, 89, 21, 34, 44 };
            //even numbers using for loop
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i] % 2 == 0) 
                Console.WriteLine(data[i]);
            }

            //even numbers using foreach loop
            foreach (var d in data)
            {
                if (d % 2 == 0)
                    Console.WriteLine(d);
            }

            //using lamda
            data.ForEach(x => Console.WriteLine(x));

            data.Where(d => d % 2 == 0).ToList().ForEach(d => Console.WriteLine(d));

            //using LINQ
            var result = from d in data
                         where d % 2 == 0
                         select d;
            result.ToList().ForEach(d => Console.WriteLine());

            Console.ReadLine();
        }

    }
}
