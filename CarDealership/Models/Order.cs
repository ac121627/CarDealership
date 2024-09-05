using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarDealership.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Required]
        public int CustomerId   { get; set; }
        public Customers Customers { get; set; }

        
        public int StaffId { get; set; }
        [ForeignKey(nameof(StaffId))]
        public Staff Staff { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public Car Car { get; set; }
    }
}
