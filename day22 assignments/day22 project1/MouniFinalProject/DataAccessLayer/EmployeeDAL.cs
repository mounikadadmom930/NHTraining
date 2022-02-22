using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static class EmployeeDAL
    {
        public  static string filepath = "C:\\Users\\mouni\\my html/EmployeeData";
        public  static bool AddEmployee(int empId,string empname,int empsalary,int empAge)
        {
            try
            {
                string textcontent = string.Concat(empId, ",", empname, ",", empsalary, ",", empAge, ",");
                File.AppendAllText(filepath, textcontent + Environment.NewLine);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static List<string> GetEmployeeById(int id)
        {
            var allEmployees = File.ReadAllLines(filepath);
            bool isFound = false;

            List<string> EmployeeFound = new List<string>();
            foreach (string employee in allEmployees)
            {
                var empDetails = employee.Split(',');
                if (Convert.ToInt32(empDetails[0]) == id)
                {
                    isFound = true;
                    EmployeeFound.Add(employee);
                    break;
                }
            }
            return EmployeeFound;
        }

        public static List<string> GetEmployeeByname(string name)
        {
            var allEmployees = File.ReadAllLines(filepath);
            bool isFound = false;

            List<string> EmployeeFound = new List<string>();
            foreach (string employee in allEmployees)
            {
                var empDetails = employee.Split(',');
                if ((empDetails[1]).Contains(name))
                {
                   
                    EmployeeFound.Add(employee);
                  
                }
            }
            return EmployeeFound;
        }
        public static string [] GetallEmployees()
        {
            var allEmployees=File.ReadAllLines(filepath);
            return allEmployees;    
            
        }

            }
        }


