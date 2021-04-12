
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BicycleShop.Models
{
    //Gör en tabell för produkter
         public class Product 
         {
        public Product()
        {
        }

        [Key]
            public int Product_id { get; set; }
            [Required]
            public string BicycleDesign { get; set; }
            [Required]
            public double Price { get; set; }
            public string TireSize { get; set; }
            public string NumberOfTires { get; set; }
            public string Material { get; set; }
            [ForeignKey("Colors_ID")]
            public int Colors_ID { get; set; }

        public ICollection<ProductOrder> ProductOrders { get; set; }

         }
}
