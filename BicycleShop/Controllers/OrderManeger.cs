using BicycleShop.Controllers;
using BicycleShop.Data;
using BicycleShop.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleShop
{
    public class OrderManeger
    {
        public void AddOrder(int Quantity, DateTime OrderPlaced, DateTime? EndTime, int Costumer_Id, int Productid)
        {

            using (var context = new BicycleContext())
            {

                var order = new Order(Quantity, OrderPlaced, EndTime, Costumer_Id, Productid);

                context.Orders.Add(order);

                context.SaveChanges();
            }

        }
    }

 }
    

