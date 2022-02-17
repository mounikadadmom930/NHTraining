using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

//*************************************************
//Author : paluru mounika
//Purpose : Reading Data(ID) from user and get the output of the Data(Name)
//***************************************************



namespace Day_19_Project_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter ID Number: ");
            int input = Convert.ToInt32(Console.ReadLine());


            XmlDocument file = new XmlDocument();
            file.Load("D:\\xml file/employee.XML");


            foreach (XmlNode node in file.DocumentElement.ChildNodes)
            {
                foreach (XmlNode node2 in node.ChildNodes)
                {
                    bool id = node2.Name == "ID";
                    bool isIndex = (id == true ? Convert.ToInt32(node2.InnerText) : 0) == input;
                    if (id && isIndex)
                    {
                        Console.WriteLine($"The Name of the ID1 is {node2.NextSibling.InnerText}.");
                    }
                }
            }
            Console.ReadLine();



        }
    }
}


