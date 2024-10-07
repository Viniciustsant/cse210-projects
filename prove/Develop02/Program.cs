using System;
using System.Diagnostics;

//I use the Switch instead of IF/Else to make the code cleaner and avoid entries diferent than numbers, using the default, and i also create the instance Random at Journal out of GetRandomPrompt, to avoid the user to get the same prompt time after time, i also added the .Replace function at my save and Load Entry to avoid errors when using date as 07/10 because the "/" symbol.

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        

        Console.WriteLine("Welcome to your Daily Journal!");
        int userAnswer = 0;

        while (userAnswer != 5)
        {
            Console.WriteLine("Select one of the following choices:");
            Console.WriteLine("1. Add Entry");
            Console.WriteLine("2. Display Entries");
            Console.WriteLine("3. Save Entries");
            Console.WriteLine("4. Load Entries");
            Console.WriteLine("5. Exit");

            userAnswer = int.Parse(Console.ReadLine());

            switch(userAnswer)
            {
                case 1:
                string prompt = journal.GetRandomPrompt();
                Console.Write(prompt);
                string entry = Console.ReadLine();

                Entry newEntry = new Entry(prompt, entry);
                journal.AddEntry(newEntry);

                break;

                case 2:
                journal.DisplayEntries();

                break;

                case 3:
                journal.SaveEntries();

                break;

                case 4:
                journal.LoadEntries();

                break;

                case 5:
                Console.WriteLine("See you tomorrow !");
                break;

                default:
                Console.WriteLine("Invalid option, try again.");

                break;
            }

        }
    }
}