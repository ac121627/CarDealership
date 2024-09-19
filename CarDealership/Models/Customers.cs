using System.ComponentModel.DataAnnotations;

namespace CarDealership.Models
{
    public class Customers
    {
        [Key]
        public int CustomersId { get; set; }

        [Required]
        public string FirstName     { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string MobileNumber { get; set; }

        public ICollection<Order> Orders { get; set; }

    }
}
