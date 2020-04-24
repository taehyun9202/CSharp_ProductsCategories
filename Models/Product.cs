using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace ProNCat.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        public string ProductName { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:C0}")]
        public decimal Price { get; set; }

        [Required]
        public string Description { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public List<Association> Categories{ get; set; }
    }
}