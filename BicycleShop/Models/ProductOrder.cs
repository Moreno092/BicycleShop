using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BicycleShop.Models
{
    //gör en tabell för productorder
    public class ProductOrder
    {
        [Key]
        public int ProductOrder_Id { get; set; }      
        [ForeignKey("Product_id")]
        public int Product_id { get; set; }
        [ForeignKey("Order_ID")]
        public int Order_ID { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }

    }
}