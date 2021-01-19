using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCFClient1.Models;
using WCFClient1.ServiceReference1;

namespace WCFClient1.Helper
{
    public class ConverTypeHelper
    {
        public static Employee ConvertViewStudentToServiceStudent(EmployeeViewModel employeeViewModel)
        {
            var employee = new Employee
            {
                EmployeeName = employeeViewModel.EmployeeName,
                Department = employeeViewModel.Department,
                Salary = employeeViewModel.Salary,
            };
            return employee;
        }
    }
}