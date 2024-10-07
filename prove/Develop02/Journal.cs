using System;
using System.IO;
using System.Collections.Generic;
public class Journal
{
    private List<Entry> entries; 

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in entries)
        {
            entry.Display();
        }
    }

    public void SaveEntries ()
    {
        Console.Write("What is the File Name? ");
        string fileName = Console.ReadLine().Replace("/", "-");

        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Answer}");
            }
        }
        Console.WriteLine("Entries saved Successfully.");
    }

    public void LoadEntries ()
    {
        Console.Write("What is the File Name? ");
        string fileName = Console.ReadLine().Replace("/", "-");

        if (File.Exists(fileName))
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split('|');
                    if (parts.Length == 3)
                    {
                        Entry entry = new Entry(parts[1], parts[2]) 
                        {
                            Date = DateTime.Parse(parts[0]) 
                        };
                        entries.Add(entry);
                    }
                }
            }
            Console.WriteLine("Entries loaded successfully.");

        }

        else
        {
            Console.WriteLine("File not found.");
        }

    }

    private List<string> prompts = new List<string>
    {
        "What was the funniest thing that happened to you today? ",
        "What are you grateful for today? ",
        "What was the biggest challenge you faced today? ",
        "What did you learn today that you would like your children to know? ",
        "How would you rate your day today? ",
        "What would you like to improve for tomorrow that didnt go so well today? "
    };

    private Random rand = new Random();

    public string GetRandomPrompt()
    {
        return prompts[rand.Next(prompts.Count)];
    }
}