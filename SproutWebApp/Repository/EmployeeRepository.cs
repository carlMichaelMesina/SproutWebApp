using Microsoft.AspNetCore.Http;
using SproutWebApp.Models;
using System.Collections.Generic;
using SproutWebApp.Extensions;
using System.Linq;

namespace SproutWebApp.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public List<Employee> employeeList;
        ISession session;

        public List<Employee> employeeGetList()
        {
            return employeeList;
        }
        public void GetEmployeeSession(ISession sessionEmp)
        {
            session = sessionEmp;
            employeeList = session.GetObjectFromJson<List<Employee>>("EmployeeList") ?? new List<Employee>();
        }
        public Employee GetEmployee(long employeeID)
        {
            return employeeList.Where(row => row.EmployeeId == employeeID).FirstOrDefault();
        }
        public void AddEmployee(Employee employee)
        {
            employeeList = session.GetObjectFromJson<List<Employee>>("EmployeeList") ?? new List<Employee>();
            Employee Employee = new Employee();

            Employee.EmployeeId = employeeList.Count + 1;
            Employee.Name = employee.Name;
            Employee.Birthdate = employee.Birthdate;
            Employee.TIN = employee.TIN;
            Employee.Salary = employee.Salary;
            Employee.EmployeeType = employee.EmployeeType;
            Employee.Status = "P";

            if (employee.EmployeeType == "R") 
            {
                Employee.Tax = 0.12;
            }

            employeeList.Add(Employee);
            session.SetObjectAsJson("EmployeeList", employeeList);
        }
    }
}
