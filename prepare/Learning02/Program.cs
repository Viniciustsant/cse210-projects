using System;

class Program
{
    static void Main(string[] args)
    {    
        Job job1 = new Job("", "", 00.000);

        job1.Title = "Vip Department";
        job1.Company = "Novibet";
        job1.Salary = 2700.00;

        Job job2 = new Job ("", "", 0);

        job2.Title = "Customer Support";
        job2.Company = "Skill On Net";
        job2.Salary = 2500.00;

        Console.WriteLine(job1.Company);
        Console.WriteLine(job2.Company);


        //job1.DisplayJobDetails();
        //job2.DisplayJobDetails();
    }
}