using System.ComponentModel.DataAnnotations;

namespace EmployeeManagerApp.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Required]
        public string Department { get; set; }

        [Range(1, 1000000)]
        public decimal Salary { get; set; }
    }
}