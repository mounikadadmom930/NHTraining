using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7project1
{
    //AUTHOR:PALURU MOUNIKA//
    //PUPOSE:EMPLOYEE CLASS WITH THREE VARABLES AND TWO METHODES//
    class Employee
    {
        public int id;
        public string name;
        public int salary;

        public void ReadEmployee()
        {
            Console.WriteLine("Enter ID:");
            id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter name:");
            name = Console.ReadLine();

            Console.WriteLine("Enter salary:");
            salary = Convert.ToInt32(Console.ReadLine());
        }
        public void printEmployee()
        {
            Console.WriteLine($"id={id},name={name},salary={salary}");
        }
    }
        
        
        
    }
    internal class Program
    {
    

    public int id;
    public string name;
    public int salary;

    public void ReadEmployee()
    {
        Console.WriteLine("Enter ID:");
        id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter name:");
        name = Console.ReadLine();

        Console.WriteLine("Enter salary:");
        salary = Convert.ToInt32(Console.ReadLine());
    }
    public void printEmployee()
    {
        Console.WriteLine($"id={id},name={name},salary={salary}");
    }in(string[] args)
        {
        Employee emp1 = new Employee();
        emp1.ReadEmployee();
        emp1.printEmployee();

        Console.ReadLine();
        }
    }
}
