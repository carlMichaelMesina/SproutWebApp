using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SproutWebApp.Models
{
    [Serializable]
    public class Employee
    {
        public long EmployeeId { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(120, ErrorMessage = "Name should have a length of 120 and below")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Birthdate is required")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Birthdate { get; set; }

        [Required(ErrorMessage = "TIN is required")]
        [StringLength(12,ErrorMessage = "TIN should have a length of 12 and below")]
        public string TIN { get; set; }

        [Required(ErrorMessage = "Employee Type is required")]
        public string EmployeeType { get; set; }
        public double Tax { get; set; }
        public double ComputedSalary { get; set; }
        public string Status { get; set; }

        [Range(0, double.MaxValue)]
        public double Salary { get; set; }

        [Range(0, double.MaxValue)]
        public double Absences { get; set; }

        [Range(0, double.MaxValue)]
        public double Attendance { get; set; }
    }

}
