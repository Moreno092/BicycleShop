using BicycleShop.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleShop.Controllers
{
    class CustomerMenuManeger
    {
       
        public bool LoggedIn = false;
        public string username = "admin";
        public string password = "lösenord";
        public int customerId = 0;
        //Meny för Customers
        public void CustomerMenu()
        {
            //Skriver information till tabellen för customer
            Console.WriteLine("First Name: ");
            string firstname = Console.ReadLine();

            Console.WriteLine("Last Name: ");
            string lastname = Console.ReadLine();

            Console.WriteLine("Email: ");
            string email = Console.ReadLine();

            Console.WriteLine("Adress: ");
            string address = Console.ReadLine();

            Console.WriteLine("Phonenumber: ");
            int phonenumber = Convert.ToInt32(Console.ReadLine());
            //Lägger till costumer
            int customerId;
            if (Program.productmaneger.AddCustomer(firstname, lastname, email, phonenumber, address, out customerId))
            {
                customerId = customerId;
                Console.WriteLine("Customer successfully added");
            }
            
            using BicycleContext context = new BicycleContext();
            Console.WriteLine("Press 1 to see the product options");
            Console.WriteLine("Press 2 to se the most expensive bike to rent ");
            Console.WriteLine("Press 3 to rent a bike ");


            Console.WriteLine("Press 9 for EXIT");

            string input1 = Console.ReadLine();
            switch (input1)
            {
                case "1":
                    Program.productmaneger.ProductsTable();
                    break;
                case "2":

                    Program.productmaneger.ProductInformation();

                    break;
                    
                case "3":
                    Program.productmaneger.ProductsTable();
                    Console.WriteLine("What bike do you wanna rent, choose between 1-5 ");
                    int Product_id = Convert.ToInt32(Console.ReadLine());                  
                    
                    Program.ordermaneger.AddOrder(1, DateTime.Now, DateTime.Now.AddDays(10), customerId, Product_id);

                    Console.WriteLine("du har nu hyrt " + Product_id);
                    string product_id = Console.ReadLine();
                    break;

                case "9":
                    Environment.Exit(0);
                    break;
            }
            this.CustomerMenu();
        }
    }
}
