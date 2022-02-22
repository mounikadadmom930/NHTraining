using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
//**************************************
//Author:paluru mounika
//purpose:business logic layer
//**************************************

namespace BusinessLogicLeyar
{
    public class EmployeeBLL
    {
        /// <summary>
        /// AddEmployee details
        /// </summary>
        /// <param name="empId"></param>
        /// <param name="empname"></param>
        /// <param name="empsalary"></param>
        /// <param name="empAge"></param>
        /// <returns></returns>
        public static bool AddEmployee(int empId, string empname, int empsalary, int empAge)
        {
            var result = EmployeeDAL.AddEmployee(empId, empname, empsalary, empAge);


            return result;
        }
        /// <summary>
        /// get employee id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static List<string> GetEmployeeById(int id)
        {
            var result = EmployeeDAL.GetEmployeeById(id);
            return result;
        }
        /// <summary>
        /// get employee by name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static List<string> GetEmployeeByname(string name)
        {
            var result = EmployeeDAL.GetEmployeeByname(name);
            return result;
        }
        /// <summary>
        /// display all emmployee details
        /// </summary>
        /// <returns></returns>
        public static string[] GetallEmployees()
        {
            var result = EmployeeDAL.GetallEmployees();
            return result;
        }
    }
 }
