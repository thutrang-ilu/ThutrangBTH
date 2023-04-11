using System.ComponentModel.DataAnnotations;
namespace BaiThucHanh0703.Models
{
    public class Student
    {
        [Key]
        public string StudentCode { get; set; }
        public string StudentName { get; set; } //prop
        public string Address { get; set; }
    }
}