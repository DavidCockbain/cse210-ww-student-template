using System;

class Program
{
    static void Main(string[] args)
    {
        //asks for the grade 
    Console.Write("What is your grade percentage? ");
            string answer = Console.ReadLine();
            int percent = int.Parse(answer);
       
            string letter = "";
            //if and if else to check grade
            if (percent >= 90)
            {
            letter = "A";
            }
            else if (percent >= 80)
            {
            letter = "B";
            }
            else if (percent >= 70)
            {
            letter = "C";
            }
            else if (percent >= 60)
            {
            letter = "D";
            }
            else
            {
            letter = "F";
            }
            // display grade in leter form
            Console.WriteLine($"Your grade is: {letter}");
            // if and else statments for pass and fail  
            if (percent >= 70)
            {
            Console.WriteLine("You passed!");
            }
            else
            {
            Console.WriteLine("Better luck next time!");
            } 
    }
}