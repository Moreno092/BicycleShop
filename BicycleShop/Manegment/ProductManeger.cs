using BicycleShop.Data;
using BicycleShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace BicycleShop.Controllers
{
    class ProductManeger
    {
        //private static IEnumerable<Product> ;
        public void ProductInformation()
        {
            //Using Bicyclecontext visar allt i min databas
            using BicycleContext context = new BicycleContext();

        //Visar en specefik vara över 50000 kr
            var products = from product in context.Products
                           where product.Price > 50000
                           orderby product.Product_id
                           select product;
            
            foreach (Product p in products)
            {
                Console.WriteLine($"Id:             {p.Product_id}");
                Console.WriteLine($"Design:         {p.BicycleDesign}");
                Console.WriteLine($"Price:          {p.Price} ");
                Console.WriteLine($"TireSize:        {p.TireSize}");
                Console.WriteLine($"Material:        {p.Material}");
                Console.WriteLine($"NomerOfTiers:    {p.NumberOfTires}");
                Console.WriteLine($"Color:            {p.Colors_ID}");
            }

        }

        //Lägger till kunder
        public bool AddCustomer(string firstname, string lastName, string email, int phonenumber, string address, out int customerId)
        {
            using (var context = new BicycleContext())
            {
                var CustomerAdd = new Customer(firstname,  lastName,  email,  phonenumber, address);

                context.Customers.Add(CustomerAdd);
                if (CustomerAdd == null)
                {
                    Console.Clear();
                    Console.WriteLine("Add Customer faild");
                    RemoveCustomer();
                }
                context.SaveChanges();

                customerId = CustomerAdd.Customer_Id;
                return true;
            }

            customerId = 0;
            return false;
        }// Tar bort Kunder
        public void RemoveCustomer()
        {
            Console.WriteLine("Enter the Customer ID you want to delete");

            int customerIdToDelete = Convert.ToInt32(Console.ReadLine());
            using (var context = new BicycleContext())
            {
                var customerToDelete = context.Customers.Find(customerIdToDelete);
                if (customerToDelete == null)
                {
                   Console.Clear();
                   Console.WriteLine("You have entered an Id that doesn't exist, try again");
                   RemoveCustomer();
                }
                context.Customers.Remove(customerToDelete);
                context.SaveChanges();
                
            }
        }
        //Uppdaterar Kunder
        public void UpdateCustomerAdress()
        {

            Console.WriteLine("Type the Customer ID for update");
            int _Customer_ = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type for Update Address");
            string address = Console.ReadLine();
            


            using (var context = new BicycleContext())
            {

                var CustomerToBeUppdated = context.Customers.FirstOrDefault(b => b.Customer_Id == _Customer_);


              
                if (CustomerToBeUppdated != null)
                {
                    CustomerToBeUppdated.Address = address;                 
                    context.Update(CustomerToBeUppdated);
                    context.SaveChanges();
                    UpdateCustomerAdress();
                }
                if (CustomerToBeUppdated == null)
                {
                    Console.Clear();
                    Console.WriteLine("You have entered an Id that doesn't exist, try again");
                }



            }
        }
            //Hämtar information ifrån utvald tabell 
            public Product GetProductById(int id)
        {
            using BicycleContext context = new BicycleContext();
            var returnProduct = context.Products.FirstOrDefault(p => p.Product_id == id);
            Console.WriteLine("ID: " + returnProduct.Product_id + ", Name: " + returnProduct.BicycleDesign + ", Price: " + returnProduct.Price + ", TireSize: " + returnProduct.TireSize + ", NumberOfTires: " + returnProduct.NumberOfTires + ", Material: " + returnProduct.Material + ", Color: " + returnProduct.Colors_ID);
            return returnProduct;
        }
        //Gjort en lista på alla produkter som finns i databasen
        public void ProductsTable()
        {
            using (var result = new BicycleContext())
            {
                List<Product> products = result.Products.ToList();
                foreach (Product product in products)
                {
                    Console.WriteLine($"Id:             {product.Product_id}");
                    Console.WriteLine($"Design:         {product.BicycleDesign}");
                    Console.WriteLine($"Price:          {product.Price} ");
                    Console.WriteLine($"TireSize:        {product.TireSize}");
                    Console.WriteLine($"Material:        {product.Material}");
                    Console.WriteLine($"NomerOfTiers:    {product.NumberOfTires}");
                    Console.WriteLine($"Color:            {product.Colors_ID}");
                } 
                
            }
        }
    }

    }
        
    

