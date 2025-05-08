using System;

class Program
{
    static void Main(string[] args)
    {
        //welcome mesage and numlist start
        Console.WriteLine("welcome to the number adder app!");
        List<int> numList = new List<int>();
            
        // start of usermun
        int userNum = -1;
        while (userNum != 0)
        {
        Console.Write("Enter a number to add or (0 to see the sum and quit): ");
                
        string userResponse = Console.ReadLine();
        userNum = int.Parse(userResponse);
                
        // adding usernum to num list 
        if (userNum != 0)
        {
        numList.Add(userNum);
        }
        }
    
        //quit and give sum
        int sum = 0;
        foreach (int number in numList)
        {
        sum += number;
        }
    
        Console.WriteLine($"the sum is: {sum}");
    
            
            // give ave
        float ave = ((float)sum) / numList.Count;
        Console.WriteLine($"the average is: {ave}");
    
            //give max
            
        int max = numList[0];
    
        foreach (int number in numList)
        {
            if (number > max)
            {
                    
            max = number;
            }
        }
    
            Console.WriteLine($"The max is: {max}");
        }
}