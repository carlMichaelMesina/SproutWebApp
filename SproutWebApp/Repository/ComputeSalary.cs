using Microsoft.AspNetCore.Http;
using SproutWebApp.Models;

namespace SproutWebApp.Repository
{
    public abstract class ComputeSalary
    {
        public abstract Employee ComputeEmployeeSalary();
    }
}
