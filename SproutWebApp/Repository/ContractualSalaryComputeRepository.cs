using Microsoft.AspNetCore.Http;
using SproutWebApp.Models;
using System.Collections.Generic;
using SproutWebApp.Extensions;
using System.Linq;
using System;

namespace SproutWebApp.Repository
{
    public class ContractualSalaryComputeRepository : ComputeSalary
    {
        public readonly ISession _session;
        public readonly Employee _employee;

        public ContractualSalaryComputeRepository(ISession session, Employee employee)
        {
            _session = session;
            _employee = employee;
        }

        public override Employee ComputeEmployeeSalary()
        {
            List<Employee> employeeList = _session.GetObjectFromJson<List<Employee>>("EmployeeList") ?? new List<Employee>();
            Employee Employee = employeeList.FirstOrDefault(x => x.EmployeeId == _employee.EmployeeId);

            Employee.Attendance = _employee.Attendance;
            Employee.ComputedSalary = Employee.Salary * Employee.Attendance;
            Employee.Status = "A";

            _session.SetObjectAsJson("EmployeeList", employeeList);

            return Employee;

        }
    }
}
