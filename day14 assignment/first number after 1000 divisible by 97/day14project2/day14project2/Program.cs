using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day14project2
{
    class Student
    {
        public int Id { get; set; } 
        public string Name { get; set; }    
        public string Mail { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Id = 101;
            student.Name = "mounika";
            student.Mail = "mouni@gmail.com";
            Console.WriteLine(student.Id);
            Console.WriteLine(student.Name);
            Console.WriteLine(student.Mail);
            Console.ReadLine();
        }
    }
}
