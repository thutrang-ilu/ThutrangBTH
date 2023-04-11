using System.ComponentModel.DataAnnotations;
namespace BaiThucHanh0703.Models
{
    public class Person
    {
        [Key]
        public string PersonID { get; set; }
        public string PersonName { get; set; } //prop
        public string PersonPhone { get; set; }
    }
}