using System.Reflection.Metadata.Ecma335;
using System;
using System.Collections.Generic; 

public class Resume
{
    public string Name {get; set; }
    
    public List<Job> Jobs {get; set; } = new List<Job>();

    public void DisplayResume()
    {
       Console.WriteLine($"Name: {Name}\n");
       Console.WriteLine("Jobs:");

        foreach (Job job in Jobs)
        {
            job.DisplayJobDetails();
        }
    }
}