using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BicycleShop.Models
{
   
    //Gör en tabell för color
        public class Color
        {
            [Key]
            public int Colors_ID { get; set; }
           [MaxLength (50)]
            public string ColorName { get; set; } 
            public ICollection<ProductOrder> products { get; set; }
        }
    
}