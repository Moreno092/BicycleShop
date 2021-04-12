using BicycleShop.Controllers;
using BicycleShop.Data;
using BicycleShop.Implements;
using BicycleShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace BicycleShop
{
    class Program
    {
        //Hämtar klasser till Program.cs
        public static Menu menu = new Menu();
        public static ProductManeger productmaneger = new ProductManeger();
        public static ColorImplement colorManeger = new ColorImplement();
        public static OrderManeger ordermaneger = new OrderManeger();
        public static ProductImplement productImplement = new ProductImplement();
        public static AdminManeger adminManeger = new AdminManeger();
        public static CustomerMenuManeger customerMenuManeger = new CustomerMenuManeger();
        static void Main(string[] args)
        {
           // productImplement.Addinformarion();


            //Hämtar klassen menu för att kunna köra den
            while (true)
            {
                //menu.StartMeny();
                menu.MainMenu();
                //menu.CustomerMenu();
            }
            //colorManeger.AddColorInformation();
        }

    }
 }
     

