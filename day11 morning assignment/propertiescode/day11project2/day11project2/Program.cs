using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//********************************************
//AUTHOR:PALURU MOUNIKA
//PURPOSE:SAMPLE CODE TO ILLUSTRATE PROPERTY
//*******************************************

namespace Property_Example
{
    class Employee
    {
        private int id;
        private string name;
        private string designation;
        private int salary;
        /// <summary>
        /// Id
        /// </summary>

        public int Id
        {
            get { return id; }
            set { id = 101; }
        }
        /// <summary>
        /// name
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = "pavani"; }

        }
        /// <summary>
        /// designation
        /// </summary>
        public string Designation
        {
            set { designation = value; }
        }
        /// <summary>
        /// salary
        /// </summary>
        public int Salary
        {
            get
            {
                salary = (designation == "s") ? 30000 : 60000;
                return salary;
            }

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Id = 101;
            Console.WriteLine(emp.Id);
            emp.Name = "pavani";
            Console.WriteLine(emp.Name);
            emp.Designation = "s";
            Console.WriteLine(emp.Salary);

            Console.ReadLine();
        }
    }
}
