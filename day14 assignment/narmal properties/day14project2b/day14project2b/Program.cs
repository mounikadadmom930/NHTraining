using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//************************************************
//Author:paluru mounika
//purpose:program to illustrate the normal property
//************************************************

namespace day14project2b
{
    class Student
    {
        private int id;
        private string name;    
        private string mail;
        public int Id
        {
            get { return id; }  
            set { id = 101; } 
        }
        public string Name
        {
            get { return name; }    
            set { name = "pavani"; }   
        }
        public string Mail
        {
            get { return mail; }    
            set { mail = "pavani@gmail.com"; }   
        }
            

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Id = 101;
            student.Name = "pavani";
            student.Mail = "pavani@gmail.com";
            Console.WriteLine(student.Id);
            Console.WriteLine(student.Name);    
            Console.WriteLine(student.Mail);
            Console.ReadLine();

        }
    }
}
