using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//************************************
//AUTHOR:PALURU MOUNIKA
//PURPOSE:TO PRINT MATH OPARATIONS
//****************************************

namespace day11project3
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public int Salary { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Id = 104;
            Console.WriteLine($"id = {emp.Id}");
            emp.Name = "madhavi";
            Console.WriteLine($"name = {emp.Name}");
            emp.Designation = "scrummaster";
            Console.WriteLine($"designation = {emp.Designation}");
            emp.Salary = 60000;
            Console.WriteLine(emp.Salary);
            Console.ReadLine();

        }
    }
}