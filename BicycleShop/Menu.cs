using System;
using System.Collections.Generic;
using System.Text;
using BicycleShop.Controllers;
using BicycleShop.Data;
using BicycleShop.Models;
using Polly;

namespace BicycleShop
{

    public class Menu
    {
        public bool LoggedIn = false;
        public string username = "admin";
        public string password = "Felipebordefåvg";





        //public int id;
       
        public void MainMenu()
        {
            Console.WriteLine("****WELCOME TO FELIPES RENT A BIKESHOP****");
            Console.WriteLine("Press( 1 ) to log in as Admin  or press ( 2 )to rent a bike as a customer ");
            string input1 = Console.ReadLine();
            if (input1 == "1")
            {
                StartMeny();
            }
            else if(input1 == "2")
            {
                Program.customerMenuManeger.CustomerMenu();
            }
        }


        public void StartMeny()
        {

                if (LoggedIn == false) {
                    Console.WriteLine("Skriv ditt användarnamn: (Correct username is'admin')");
                    string userInput = Console.ReadLine();
                    Console.WriteLine("Skriv ditt lösenord: (Correct parrword is 'Felipebordefåvg'(Small f))");
                    string passInput = Console.ReadLine();
                    Console.WriteLine();
                    if (this.username.ToLower() == userInput.ToLower() && this.password.ToLower() == passInput.ToLower())
                    {
                        this.LoggedIn = true;
                    }
                  
                }
                if(this.LoggedIn == true)
                {
                   Program.adminManeger.AdminMenu();
                }

            this.MainMenu();

        }
  
        }
    }


