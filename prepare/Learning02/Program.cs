using System;

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
        myResume.DisplayResumeDetails();

        
    }
}