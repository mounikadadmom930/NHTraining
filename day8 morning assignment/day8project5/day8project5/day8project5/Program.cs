using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8project5
{
    internal class Bank_1
    {
        class Bank
        {
            public int Id;
            public string Name;
            public int Income;
        }

        static void Main(string[] args)
        {
            /********************************
             * Author:paluru mounika
             * Purpose:bank class more than 600000
             ********************************/

            List<Bank> Bank = new List<Bank>()
            {
                new Bank() { Id = 1, Name = "Andra", Income = 400000 },

                new Bank() { Id = 2, Name = "sbi", Income = 70000 },

                new Bank() { Id = 3, Name = "hdfc", Income = 1000000 },

                new Bank() { Id = 4, Name = "icic", Income = 30000 }
            };
            //Print the values using for loop

            for (int i = 0; i < Bank.Count; i++)

            {
                if (Bank[i].Income >60000)
                    Console.WriteLine($"Id={Bank[i].Id},Name={Bank[i].Name},Income={Bank[i].Income}");
            }


            //Print the values using foreah loop

            foreach (var b in Bank)
            {
                if (b.Income >60009)
                    Console.WriteLine($"Id={b.Id},Name={b.Name},income={b.Income}");
            }

            //Print values using Lambda Expression

            Bank.ToList().Where(b => b.Income >60000).ToList().ForEach(b => Console.WriteLine($"Id={b.Id},Name={b.Name},income={b.Income}"));

           //print the values using LINQ

           var result=from b in Bank
                      where b.Income>60000
                      select b.Name;
        result.ToList().ForEach(b => Console.WriteLine(b));

            Console.ReadLine();

        }

    }
}

