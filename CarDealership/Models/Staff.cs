using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarDealership.Models
{
    public class Staff
    {
        [Key]
        public int StaffId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string PhoneNumber { get; set; }
        

        public int StoreID { get; set; }
        public Store Store { get; set; }

        public ICollection<Order> Orders { get; set; }
        
    }
}