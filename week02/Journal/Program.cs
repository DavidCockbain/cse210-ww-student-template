using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
{
        
        Journal journal = new Journal("","","");
        

        
        Console.WriteLine("Welcome to Your Daily Journal!");
    
        while (true) {
            Console.WriteLine("Please select one of the follwing choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
        
            Console.Write("What would you like to do? ");
            string choice = Console.ReadLine();

            
            
        

            if (choice == "1")
            {
            journal.AddEntry("","","");
            }

            if (choice == "2")

            {
                journal.DisplayEntries();
            
            }


            if (choice == "3")
            {
                 journal.LoadFromFile();
            }


            if (choice == "4")
            {
                 journal.SaveToFile();
            }


            if (choice == "5")
            {
                Console.WriteLine("Goodbye!");
            }


            else 
            {
                    Console.WriteLine("Invalid selection, please enter a number 1-5.");
            }
            
        }
    }
}