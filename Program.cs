using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Login
{
    class Program
    {
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
            var users = new Dictionary<string, string>(){
                {"user1", "pass1"},
                {"user2", "pass2"},
                {"user3", "pass3"}
            };
            Console.WriteLine("Starting");

            string user = username();
            string pass = password();
            int tryCount = 1;

            if(users.ContainsKey(user) && pass == users[user]){
                Console.WriteLine("You're logged in");
            }
            else{
                while((users.ContainsKey(user) && pass == users[user]) == false){
                    Console.WriteLine("Invalid login");
                    user = username();
                    pass = password();
                    tryCount++;
                    if(tryCount == 3){
                        Console.WriteLine("Do you want to register? y/n");
                        string choice = Console.ReadLine();
                        if(choice == "y"){
                            user = username();
                            pass = password();
                            users.Add(user, pass);
                            Console.WriteLine("You're registered and logged in!");
                        }
                        else if(choice == "n"){
                            tryCount = 0;
                        }
                    }
                }
            }
        }
    }
}
