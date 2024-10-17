using System;
/*For exceeding requirements i added 3 scriptures in a list to be the default scriptures and created a menu so the user 
can choose one of the defaults or he can also add his own scripture, and use it to memorize, the code will record this scripture
and shows it in the screen*/
class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = null;
        Console.WriteLine("Welcome to the Scripture Memorizer");
        Console.Write("Do you wanna use a default scripture or enter your own? (write 'default' or 'enter') ");
        string choice = Console.ReadLine();

        if (choice.ToLower() == "default")
        {
            List<Scripture> defaultScriptures = new List<Scripture>
            {
                new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all your heart; and lean not on your own understanding. In all your ways acknowledge Him, and He shall direct your paths."),
                new Scripture(new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
                new Scripture(new Reference("1 Nephi", 3, 7), "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.")
            };

            for (int i = 0; i < defaultScriptures.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {defaultScriptures[i].GetDisplayText()}");
            }
            
            Console.Write("Choose a scripture (1, 2, or 3): ");
            int selectedIndex = int.Parse(Console.ReadLine());
            scripture = defaultScriptures[selectedIndex - 1 ];
        }
        else if (choice.ToLower() == "enter")
        {
            Console.Write("Enter the book: ");
            string book = Console.ReadLine();

            Console.Write("Enter the chapter: ");
            int chapter = int.Parse(Console.ReadLine());

            Console.Write("Enter the verse: ");
            int verse = int.Parse(Console.ReadLine());

            Console.Write("Enter the full Scripture: ");
            string text = Console.ReadLine();

            scripture = new Scripture(new Reference(book, chapter, verse), text);
        }

        while (true)
        {
            Console.Clear();
            Console.WriteLine("\n");
            Console.WriteLine(scripture.GetDisplayText());

            Console.Write("Press Enter to hide some words or type 'quit' to exit: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine("All words are now hidden. You did it!");
                break;
            }
        }
    }
}