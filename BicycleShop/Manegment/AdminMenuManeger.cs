using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleShop.Controllers
{
    class AdminMenuManeger
    {
        public int customerId;
        
        //Menyn för Admin
        public void AdminMenu()
        {
            Console.WriteLine("Welcome Admin!");
            Console.WriteLine("Press 1 to add customer ");
            Console.WriteLine("Press 2 to delete customer");
            Console.WriteLine("Press 3 to create order");
            Console.WriteLine("Press 4 to update customer address");
            Console.WriteLine("Press 8 to im implement product context ");
            Console.WriteLine("Press 9 to implement Color context ");
            

            string input1 = Console.ReadLine();

            switch (input1)
            {

                case "1":
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

                    int customerId;
                   if( Program.productmaneger.AddCustomer(firstname, lastname, email, phonenumber, address, out customerId))
                    {
                        customerId = customerId;
                        Console.WriteLine("Customer successfully added");
                    }
                    break;
                case "2":
                    Program.productmaneger.RemoveCustomer();
                    break;

                case "3":
                    Program.productmaneger.ProductsTable();
                    Console.WriteLine("What bike do you wanna channge to customer, choose between 1-5 ");
                    int Product_id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("choose customer ");
                    customerId = Convert.ToInt32(Console.ReadLine());
                   
                    Program.ordermaneger.AddOrder(1, DateTime.Now, DateTime.Now.AddDays(10), customerId, Product_id);

                    Console.WriteLine("du har nu hyrt " + Product_id);
                    string roduct_id = Console.ReadLine();
                    break;
                case "4":
                    Program.productmaneger.UpdateCustomerAdress();
                    break;
                case "8":
                    Program.productImplement.Addinformarion();
                    break;
                case "9":
                    Program.colorManeger.AddColorInformation();
                    
                    break;


                   
            }
        }
    }
}

