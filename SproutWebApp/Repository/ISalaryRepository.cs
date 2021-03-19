using Microsoft.AspNetCore.Http;
using SproutWebApp.Models;
using System.Collections.Generic;

namespace SproutWebApp.Repository
{
    public interface ISalaryRepository
    {
        Employee SaveSalary(ISession session, Employee employee, long employeeID);
    }

}
