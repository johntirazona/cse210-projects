using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        List<int> numbers = new List<int>();

        int input = -1;

        while (input != 0)
        {
            Console.Write("Enter number: ");
            string answer = Console.ReadLine();
            input = int.Parse(answer);

            if (input != 0)
            {
                numbers.Add(input);
            }

        }

        float totalSum = numbers.Sum();

        Console.WriteLine($"The total is {totalSum}");

        float average = ((float)totalSum) / numbers.Count;

        Console.WriteLine($"The average is {average}");

        int largestNumber = numbers.Max();

        Console.WriteLine($"The largest of number is: {largestNumber}");
    }
}
