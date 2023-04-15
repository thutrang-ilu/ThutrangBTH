using System.ComponentModel.DataAnnotations;

namespace BTH1004.Models
{
    public class Employee
    {
        [Key]
        public string EmployeeID { get; set; }
        public string EmployeeName { get; set; } //prop
        public string EmployeeAddress { get; set; }
    }
}