using System;
using System.Text.Json.Serialization;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job
        {
            _companyName = "Computer Engineering Works",
            _jobTitle = "Chief Executive Officer",
            _startYear = 2012,
            _endYear = 2021,
        };
        
        Job job2 = new Job
        {
            _companyName = "Saret Computer Workshop",
            _jobTitle = "Chief Engineer",
            _startYear = 1995,
            _endYear = 2010,
        };

        Resume myResume = new Resume
        {
            _nameOfPerson = "Kevin Ouma Ogutu",      
        };
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        WriteToFile(myResume);     
    }
    public static void WriteToFile(Resume myResume)
    {
        Console.WriteLine("Writing to file.....");
        string nameOfFile = "jobs.txt";
        using (StreamWriter outputJob = new StreamWriter(nameOfFile))
        {
            outputJob.WriteLine("Job I have done:");
            foreach (Job j in myResume._jobs)
            {
                outputJob.WriteLine(j._companyName);
            }
        }


    }
}