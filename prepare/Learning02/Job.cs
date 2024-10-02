public class Job
{
    public string Title { get; set; }
    public string Company { get; set; }
    public double Salary { get; set; }

    public Job(string title, string company, double salary)
    {
        Title = title;
        Company = company;
        Salary = salary;
    }

    public void DisplayJobDetails()
    {
        Console.WriteLine($"Title: {Title}, Company: {Company}, Salary: {Salary}");
    }
}
