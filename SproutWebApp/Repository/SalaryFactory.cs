using Microsoft.AspNetCore.Http;
using SproutWebApp.Models;

namespace SproutWebApp.Repository
{
    public class SalaryFactory: ISalaryRepository
    {
        public ComputeSalary GetSalaryComputation(ISession session, Employee employee)
        {
            if (employee.EmployeeType == "R")
                return new RegularSalaryComputeRepository(session, employee);
            else
                return new ContractualSalaryComputeRepository(session, employee);
        }
    }
}
