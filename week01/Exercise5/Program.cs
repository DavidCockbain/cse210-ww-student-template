using System;

class Program
{
    static void Main(string[] args)
    {
    //start
    DisplayWelcomeMessage();

    string userName = PromptUserName();
    int usernum = PromptUsernum();

    int squarednum = Squarenum(usernum);

    DisplayResult(userName, squarednum);
    }

    static void DisplayWelcomeMessage()
    // welcome message
    {
    Console.WriteLine("Welcome to the name and number program!");
    }
    //enter name 
    static string PromptUserName()
    {
    Console.WriteLine("Please enter your name: ");
    string name = Console.ReadLine();

    return name;
    }
    //enter number
    static int PromptUsernum()
    {
    Console.Write("Please enter your favorite number: ");
    int num = int.Parse(Console.ReadLine());

    return num;
    }
    //square number
    static int Squarenum(int num)
    {
    int square = num * num;
    return square;
    }
    // disply squared number and name
    static void DisplayResult(string name, int square)
    {
    Console.WriteLine($"{name}, the square of your numberd is {square}");
    }
}