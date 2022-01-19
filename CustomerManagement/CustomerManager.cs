using System;
using TurboCollections;

namespace CustomerManagement{
    class program{
        static void Main(string[] args){
            var CustomerList = new TurboList<string>();
            bool open = true;
            Console.WriteLine("Hello! Choose an option:");
            while (open){
                Console.WriteLine("1: Add a customer");
                Console.WriteLine("2: Remove a customer by name");
                Console.WriteLine("3: Remove a customer by index");
                Console.WriteLine("4: Display all customers");
                Console.WriteLine("5: terminate the program");
                var userInput = Console.ReadLine();
                if (userInput == "1"){
                    Console.WriteLine("Please enter the name of the customer.");
                    CustomerList.Add(Console.ReadLine());
                    continue;
                }
                if (userInput == "2"){
                    Console.WriteLine("Please state the customer you want to remove");
                    CustomerList.Remove(Console.ReadLine());
                    continue;
                }

                if (userInput == "3"){
                    Console.WriteLine("Please state at what index you would like to remove the customer");
                    int reply = Convert.ToInt32(Console.ReadLine());
                    CustomerList.RemoveAt(reply);
                    continue;
                }

                if (userInput == "4"){
                    for (int i = 0; i < CustomerList.Count; i++){
                        Console.WriteLine($"{i+1}: {CustomerList.Get(i)}");
                    }
                    continue;
                }
                if (userInput == "5"){
                    open = false;
                }
                else{
                    Console.WriteLine("That is not a valid input, try again!");
                }
            }
        }
    }

    
    
    internal class Customers{
        int id{ get;}
        string name{ get; set; }
    } //WIP dont bother..
}