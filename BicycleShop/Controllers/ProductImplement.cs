using BicycleShop.Data;
using BicycleShop.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleShop.Implements
{
    class ProductImplement
    {
        //lägger till informartion i tabellerna
         public void Addinformarion()
         {

             using BicycleContext context = new BicycleContext();

             Product BMX = new Product()
             {
                 BicycleDesign = "BMX",
                 Price = 15000,
                 TireSize = "Small(18'')",
                 NumberOfTires = "Two",
                 Material = "Steel",
                 Colors_ID = 1
             };
             context.Add(BMX);
             Product TreiningBike = new Product()
             {
                 BicycleDesign = "Treining bike",
                 Price = 500,
                 TireSize = "Small(12'')",
                 NumberOfTires = "Three",
                 Material = "Plastic",
                 Colors_ID = 2

             };
             context.Add(TreiningBike);
             Product TerrainBike = new Product
             {
                 BicycleDesign = "Terrain bike",
                 Price = 8999.99,
                 TireSize = "Big(29'')",
                 NumberOfTires = "Two",
                 Material = "Steel",
                 Colors_ID = 2
             };
             context.Add(TerrainBike);
             Product SportBike = new Product
             {
                 BicycleDesign = " Sport bike",
                 Price = 25000,
                 TireSize = "Small(18'')",
                 NumberOfTires = "Two",
                 Material = "carbon fiber",
                 Colors_ID = 3
             };
             context.Add(SportBike);
             Product WorldsBestBike = new Product
             {
                 BicycleDesign = " Worlds best bike",
                 Price = 99999.99,
                 TireSize = "hovering",
                 NumberOfTires = "Two",
                 Material = "Diamond",
                 Colors_ID = 4
             };
             context.Add(WorldsBestBike);
             context.SaveChanges();
         }
    }
}
