using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Login
{
    class Program
    {
        static void login(){
                Console.WriteLine("--Starting Functing things--");
                Console.WriteLine("Username: ");
                string username = Console.ReadLine();
                
            }
            static string username(){
                Console.WriteLine("Username: ");
                string username = Console.ReadLine();
                return username;
            }
            static string password(){
                Console.WriteLine("Password: ");
                string password = Console.ReadLine();
                return password;
            }
        static void Main(string[] args)
        {
            var users = new Dictionary<string, string>();
            Console.WriteLine("Starting");

            string user = username();
            string pass = password();


            Console.WriteLine("User name is: " + user);
            Console.WriteLine("Password is: " + pass);
        }
    }
}
