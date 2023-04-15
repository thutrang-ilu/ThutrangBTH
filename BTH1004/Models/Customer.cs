using System.ComponentModel.DataAnnotations;

namespace BTH1004.Models
{
    public class Customer
    {
        [Key]
        public string CustomerID { get; set; }
        public string CustomerName { get; set; } //prop
        public string CustomerAddress { get; set; }
        public int CustomerPhone { get; set; }
    }
}