using Microsoft.AspNetCore.Http;
using SproutWebApp.Models;
using System.Collections.Generic;

namespace SproutWebApp.Repository
{
    public interface ISalaryRepository
    {
        ComputeSalary GetSalaryComputation(ISession session, Employee employee);
    }

}
