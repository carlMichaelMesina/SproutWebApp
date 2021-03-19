using Microsoft.AspNetCore.Http;
using SproutWebApp.Models;
using System.Collections.Generic;

namespace SproutWebApp.Repository
{
    public interface IEmployeeRepository
    {
        void GetEmployeeSession(ISession session);
        List<Employee> employeeGetList();
        Employee GetEmployee(long employeeID);
        void AddEmployee(Employee employee);
    }

}
