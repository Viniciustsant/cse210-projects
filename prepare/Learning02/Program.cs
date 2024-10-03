using System;

class Program
{
    static void Main(string[] args)
    {    
        Job job1 = new Job("", "", 0, 0);

        job1.Title = "Vip Department";
        job1.Company = "Novibet";
        job1.StartYear = 2022;
        job1.EndYear = 2024;

        Job job2 = new Job ("", "", 0, 0);

        job2.Title = "Customer Support";
        job2.Company = "Skill On Net";
        job2.StartYear = 2020;
        job2.EndYear = 2022;

        //Console.WriteLine(job1.Company);
        //Console.WriteLine(job2.Company);

        //job1.DisplayJobDetails();
        //Console.WriteLine();
        //job2.DisplayJobDetails();

        Resume resume = new Resume();
        resume.Name = "Vinicius Santiago";
        
        resume.Jobs.Add(job1);
        resume.Jobs.Add(job2);

        //Console.WriteLine($"{resume.Jobs[0].Title}");

        resume.DisplayResume();
    }
}