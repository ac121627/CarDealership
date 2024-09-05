using System.ComponentModel.DataAnnotations;

namespace CarDealership.Models
{
    public class Store
    {
        [Key]
        public int StoreId { get; set; }

        [Required]
        public string Address { get; set; }

        public ICollection<Car> Cars { get; set; }

        public ICollection<Staff> Staff { get; set; }


    }
}
