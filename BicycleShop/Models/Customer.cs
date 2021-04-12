using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BicycleShop.Models
{
    public class Customer
    {
      
        public Customer()
        {

        }

        public Customer(int customer_Id)
        {
            Customer_Id = customer_Id;
        }

        public Customer( string firstname, string lastName, string email, int phonenumber, string address)
        {
            
            FirstName =  firstname;
            LastName = lastName;
            Email = email;
            PhoneNumber = phonenumber;
            Address = address;
        }

        //Gör en tabell för kunder
        [Key]
        public int Customer_Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
      
        public ICollection<Order> Orders { get; set; }
    }
}
