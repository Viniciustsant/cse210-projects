using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.Write("What is the magic number? ");
        //string number = Console.ReadLine();
        //int magicNumber = int.Parse(number);
        Random number = new Random();
        int magicNumber = number.Next(1,100);

        int guess = 0;

        while (guess != magicNumber)
        {
            Console.Write("What is your Guess? ");
            string userGuess = Console.ReadLine();
            guess = int.Parse(userGuess);

            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }

            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }

            else 
            {
                Console.WriteLine("You Guessed it!");
            }
        } 
    }
}