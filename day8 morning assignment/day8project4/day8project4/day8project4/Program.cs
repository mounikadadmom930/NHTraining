﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//**********************************************************
//AUTHOR:PALURU MOUNIKA
//PUPOSE:TO PRINT WHICH DEPARTMENT IS MORE THAN 50
//**********************************************************

namespace department_class_using_4_loops
{
    class Department
    {
        public int id;
        public string name;
        public int empcount;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           List< Department> department = new List<Department>
            {
                new Department(){ id = 1, name ="software developer",empcount=51},
                new Department(){ id = 2, name ="scrum master",empcount =30},
                new Department(){ id = 3, name ="c# devoloper", empcount =100},
                new Department(){ id = 4, name ="qa automachine", empcount=29},
                new Department(){ id = 5, name ="qa manual",empcount=(63)}
            };
            Console.WriteLine("******************");
            //empcount >50 using FORLOOP

            for (int i = 0; i < department.Count; i++)

            {
                if (department[i].empcount > 50)
                    Console.WriteLine($"id={department[i].id},name={department[i].name}");
            }
            Console.WriteLine("******************");
            // empcount >50 using FOREACH LOOP
            foreach (var e in department)
            {
                if (e.empcount > 50)
                    Console.WriteLine($"id={e.id},name={e.name}");
            }
            Console.WriteLine("******************");
            // empcount >50 using LAMBDA EXPRESSION
            department.ToList().Where(e => e.empcount > 50).ToList().ForEach(e => Console.WriteLine($"id={e.id},name={e.name}"));
            Console.WriteLine("********************");
            // empcount >50 using LINQ query
            var result = from e in department
                         where e.empcount > 50
                         select e;
            result.ToList().ForEach(e => Console.WriteLine($"id={e.id},name={e.name}"));




            Console.ReadLine();
        }
    }
}
