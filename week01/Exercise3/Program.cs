using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        {
        // welome message
        Console.Write("Welcome to guess the number!");
        Console.Write("please enter the range for this game from 1 to:  ");
        
        //user in and randome num gen
        Random randomGenerator = new Random();
        int usernum = int.Parse(Console.ReadLine());
        int topnum = usernum;
        int magicNum = randomGenerator.Next(1,topnum);

        int guess = -1;

        // loop for guessing
            while (guess != magicNum)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                if (magicNum > guess)
                {
                Console.WriteLine("higher");
                }
                else if (magicNum < guess)
                {
                Console.WriteLine("lower");
                }
                else
                {
                Console.WriteLine("You guessed it!");
                }

            }
        }
    }
}
        