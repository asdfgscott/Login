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

        static void login(){
            
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
            // bool userCheck = false;
            // bool passCheck = false;

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
                        }
                        else{
                            tryCount = 1;
                        }
                    }
                }
                Console.WriteLine("You're logged in");
            }

            // while(userCheck == false){
            //     if(users.ContainsKey(user) == false){
            //         Console.WriteLine("User not found");
            //         user = username();
            //     }
            //     else{
            //         userCheck = true;
            //     }
            // }

            // while(passCheck == false){
            //     if(pass != users[user]){
            //         Console.WriteLine("Password is wrong");
            //         pass = password();
            //     }
            //     else{
            //         passCheck = true;
            //     }
            // }


            // Console.WriteLine(userCheck);

            // while(users.ContainsKey(username()) == false) {
            //     Console.WriteLine("User not found");
            //     user = username();
            // }


            // if(user == users[user]){
            //     if(users.ContainsValue(pass) == false){
            //         Console.WriteLine("Password is wrong");
            //     }
            //     else{
            //         Console.WriteLine("You're logged in");
            //     }
            // }
            //Check if the combo is in the dictionary
            //If yes, check if the key matches the password entered 
            //If no, say invalid login, prompt user to register or retry
            //If register, add the user,pass to the dictionary

            // users.Add(user,pass);

            //Telling me that my inputs are being red
            // Console.WriteLine("User name is: " + user);
            // Console.WriteLine("Password is: " + users[user]);
        }
    }
}
