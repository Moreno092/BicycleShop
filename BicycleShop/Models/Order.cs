
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BicycleShop.Models
{
    public class Order
    {
        public Order()
        {

        }
        public Order(int quantity, DateTime orderPlaced, DateTime? endTime, int costumer_Id, int productid)
        {
            Quantity = quantity;
            OrderPlaced = orderPlaced;
            EndTime = endTime;
            Costumer_Id = costumer_Id;
            ProductOrder_Id = productid;
        }

        //Gör en tabell för beställningar
        [Key]
        public int Order_ID { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderPlaced { get; set; }
        public DateTime? EndTime { get; set; }
        [ForeignKey("Customer")]
        public int Costumer_Id { get; set; }
       public Customer Customer { get; set; }
        [ForeignKey("ProductOrder")]
        public int ProductOrder_Id { get; set; }
        public ICollection<ProductOrder> productOrders { get; set; }
    }
}