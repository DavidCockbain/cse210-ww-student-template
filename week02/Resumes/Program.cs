using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        // assign all infomation here to its variable
        //call all variables from their class
        Job job1 = new Job();
        job1._jobTitle = "soft-ball coach";
        job1._company = "ST Johns highschool";
        job1._startYear = 2000;
        job1._endYear = 2015;
        
        Job job2 = new Job();
        job2._jobTitle = "Macanical Engineer";
        job2._company = "Toyota";
        job2._startYear = 2016;
        job2._endYear = 2020;

        Resume resume1 = new Resume();
        resume1._firstName = "James";
        resume1._lastName = "Trent";

        // add each job and display
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1.Display();
    }
}