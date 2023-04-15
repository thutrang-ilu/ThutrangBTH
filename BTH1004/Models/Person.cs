using System.ComponentModel.DataAnnotations;

namespace BTH1004.Models
{
    public class Person
    {
        [Key]
        public string PersonID { get; set; }
        public string PersonName { get; set; } //prop
        public string PersonAddress { get; set; }
    }
}