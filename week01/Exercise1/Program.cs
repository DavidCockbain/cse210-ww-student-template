using System;

class Program
{
    static void Main(string[] args)
    {   //ask for first name.
        Console.Write("What is your first name? ");
        string first = Console.ReadLine();
        //ask for last name.
        Console.Write("What is your last name? ");
        string last = Console.ReadLine();
        //display name in james bond stile.
        Console.WriteLine($"Your name is {last}, {first} {last}.");
    }
}