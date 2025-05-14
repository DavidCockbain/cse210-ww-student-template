using System;
//class creation 
public class Job
{
    // veriable criation for job class
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;
    //passing out and display variables
    public void Display()
    {
       Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}.");
    }
}