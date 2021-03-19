using Microsoft.AspNetCore.Http;
using SproutWebApp.Models;
using System.Collections.Generic;
using SproutWebApp.Extensions;
using System.Linq;
using System;

namespace SproutWebApp.Repository
{
    public class SalaryRepository : ISalaryRepository
    {
        public Employee SaveSalary(ISession session, Employee employee, long employeeID)
        {
            List<Employee> employeeList = session.GetObjectFromJson<List<Employee>>("EmployeeList") ?? new List<Employee>();
            Employee Employee = employeeList.FirstOrDefault(x => x.EmployeeId == employeeID);

            try
            {
                if (Employee.EmployeeType == "R")
                {
                    Employee.Absences = employee.Absences;
                    Employee.ComputedSalary = Employee.Salary - (Employee.Absences * (Employee.Salary / 22)) - (Employee.Salary * Employee.Tax);
                }
                else
                {
                    Employee.Attendance = employee.Attendance;
                    Employee.ComputedSalary = Employee.Salary * Employee.Attendance;
                }

                Employee.Status = "A";

                session.SetObjectAsJson("EmployeeList", employeeList);
                return Employee;
            }
            catch (Exception)
            {
                return employee;
            }

        }
    }
}
