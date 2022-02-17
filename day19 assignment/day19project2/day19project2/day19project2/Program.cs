using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
//**************************************************
//Authore:paluru mounika
//Purpose:employee class in XML document
//**************************************************

namespace day19project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("D:\\xml file/employee.XML");
            //  XmlNode node = doc.DocumentElement.SelectSingleNode("/employees/employee");
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
             foreach(XmlNode childNode in node.ChildNodes)
                {
                    if (childNode.Name == "name") 
                    {
                        Console.WriteLine(childNode.InnerText);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}