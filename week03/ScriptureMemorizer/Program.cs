using System;
using System.Reflection.Metadata;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();
        
        
        Console.WriteLine("Welcome to the scripture memoriser app!");

        Console.WriteLine("Press enter to continue or type quit:");

        string userIn = Console.ReadLine();
        if (userIn == "quit")
        {}
        if (userIn == "Quit")
        {}
        if (userIn == "QUIT")
        { }
        else
        {
            Console.WriteLine("writing");
            scripture.GetDesplayText();
            
            // foreach w in _words()
            // {
            //     Console.WriteLine("");
            // }
            
            //Console.Clear();


        }

    }
}