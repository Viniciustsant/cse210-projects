using System;

public class Entry
{
    public DateTime Date;
    public string Prompt;
    public string Answer;

    public Entry (string prompt, string answer)
    {
        Date = DateTime.Now;
        Prompt = prompt;
        Answer = answer;
        
    }

    public void Display()
    {
        Console.WriteLine($"Date: {Date} - Prompt: {Prompt}\n'{Answer}'\n");
    }

}
