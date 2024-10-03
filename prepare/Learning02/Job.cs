using System;

public class Job
{
    public string Title { get; set; }
    public string Company { get; set; }
    public int StartYear { get; set; }
    public int EndYear {get; set; }

    public Job(string title, string company, int startYear, int endYear)
    {
        Title = title;
        Company = company;
        StartYear = startYear;
        EndYear = endYear;
    }

    public void DisplayJobDetails()
    {
        Console.WriteLine($"{Title} ({Company}) {StartYear}-{EndYear}");
    }
}
