using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int input = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        List<int> numbers = new List<int>();

        while (input != 0)
        {
            Console.Write("Enter the number: ");
            string inputNumber = Console.ReadLine();
            input = int.Parse(inputNumber);

            if (input != 0)
            {
                numbers.Add(input);
            }
        }

        //get the Sum
        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }

        Console.WriteLine($"The Sum is: {total}");

        //get the average
        float average = (float)total / numbers.Count;
        Console.WriteLine($"The Average is: {average}");

        //get the largest number
        int largest = numbers[0];

        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        
        }
        Console.WriteLine($"The Largest: {largest}");




        /*
        int total = numbers.Sum();
        Console.WriteLine($"The sum is: {total}");

        double average = numbers.Average();
        Console.WriteLine($"The Average is: {average}");

        int largest = numbers.Max();
        Console.WriteLine($"The Largest number is: {largest}");
        */
        
    }
}