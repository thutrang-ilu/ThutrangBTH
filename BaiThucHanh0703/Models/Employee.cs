using System.ComponentModel.DataAnnotations;
namespace BaiThucHanh0703.Models
{
    public class Employee
    {
        [Key]
        public string EmployeeID { get; set; }
        public string EmployeeName { get; set; } //prop
        public string EmployeeAddress { get; set; }
    }
}