using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int gradePercentage = int.Parse(grade);
        
        string letter;

        if (gradePercentage < 60)
        {
            //Console.WriteLine("Your Grade Percentage is F");
            letter = "F";
        }

        else if (gradePercentage >= 60 && gradePercentage < 70)
        {
            //Console.WriteLine("Your Grade Percentage is D");
            letter = "D";
        }

        else if (gradePercentage >= 70 && gradePercentage < 80)
        {
            //Console.WriteLine("Your Grade Percentage is C"); 
            letter = "C";  
        }

        else if (gradePercentage >= 80 && gradePercentage < 90)
        {
            //Console.WriteLine("Your Grade Percentage is B");
            letter = "B";
        }

        else 
        {
            //Console.WriteLine("Your Grade Percentage is A");
            letter = "A";
        }

        
        Console.WriteLine($"Your Grade Percentage is {letter}");
        
        //loop to see if passed or not
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations, you passed !");
        }

        else
        {
            Console.WriteLine("Unfortunately you haven't passed, but keep going and study more, you can do it.");
        }
    }
}