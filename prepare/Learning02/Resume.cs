public class Resume
{
    public string _nameOfPerson;
    public List<Job>_jobs = new List<Job>();
    public Resume()
    {}
    public void DisplayResumeDetails()
    {
        Console.WriteLine($"Name: {_nameOfPerson}");
        Console.WriteLine("Jobs:");

        foreach (Job j in _jobs)
        {
            j.DisplayJobDetails();
        }
    }

}