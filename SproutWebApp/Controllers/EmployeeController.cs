using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using SproutWebApp.Repository;
using SproutWebApp.Models;

namespace SproutWebApp.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _contextEmployee;
        private readonly ISalaryRepository _contextSalary;
        public EmployeeController(IEmployeeRepository contextEmployee, ISalaryRepository contextSalary)
        {
            _contextEmployee = contextEmployee;
            _contextSalary = contextSalary;
        }

        public IActionResult ViewAllEmployees()
        {
            _contextEmployee.GetEmployeeSession(HttpContext.Session);

            return View(_contextEmployee.employeeGetList());
        }
        public IActionResult AddEmployee()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SaveEmployee(Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return View("AddEmployee");
            }
            _contextEmployee.GetEmployeeSession(HttpContext.Session);
            _contextEmployee.AddEmployee(employee);

            return RedirectToAction("ViewAllEmployees", "Employee");

        }
        public IActionResult CalculateEmployeeSalary(long employeeID)
        {
            _contextEmployee.GetEmployeeSession(HttpContext.Session);
            return View(_contextEmployee.GetEmployee(employeeID));
        }

        [HttpPost]
        public IActionResult ApprovedEmployeeSalary(Employee employee)
        {
            ComputeSalary computeSalary = _contextSalary.GetSalaryComputation(HttpContext.Session, employee);
            return View(computeSalary.ComputeEmployeeSalary());
        }
        public IActionResult ReviewEmployeeSalary(long employeeID)
        {
            _contextEmployee.GetEmployeeSession(HttpContext.Session);
            return View("ApprovedEmployeeSalary", _contextEmployee.GetEmployee(employeeID));
            
        }
    }
}
