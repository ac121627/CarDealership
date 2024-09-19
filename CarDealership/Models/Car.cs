using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CarDealership.Models
{
    public class Car
    {
        [Key]
        public int CarId { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public string Engine { get; set; }

        [Required]
        public string Brand {  get; set; }

        public int OrderID  { get; set; }

        [ForeignKey(nameof(OrderID))]
        public Order Order { get; set; }


        public int StoreID { get; set; }
        public Store Store { get; set; }

    }
}
