using BicycleShop.Data;
using BicycleShop.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleShop.Controllers
{
    class ColorImplement
    {
        public void AddColorInformation()
        {

            using BicycleContext context = new BicycleContext();

            Color Red = new Color()
            {
                ColorName = "Red"           
           };
            context.Add(Red);
            context.SaveChanges();

            Color Gold = new Color()
            {
                ColorName = "Guld"
            };
            context.Add(Gold);
            context.SaveChanges();

            Color Black  = new Color()
            {
                ColorName = "Black"
            };
            context.Add(Black);
            context.SaveChanges();

            Color Diamond = new Color()
            {
                ColorName = "diamond "
            };
            context.Add(Diamond);
            context.SaveChanges();
        }
    }
}
