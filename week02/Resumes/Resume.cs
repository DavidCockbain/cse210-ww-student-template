using System;
// Resume class creation point
public class Resume
{
    //varible _jobs list and Name creation 
    public List<Job> _jobs = new List<Job>();

    public string _firstName;
    public string _lastName;

    //foreach loop to display all jobs in _jobs list 
    //Add names and job caption
    public void Display()
    {
        Console.WriteLine($"Name: {_firstName} {_lastName}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}