using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Console.WriteLine("Welcome to my guess the number but in C#");

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 11);

        int guess = 0;
        
        while (guess != magicNumber)
       { Console.Write("What is your guess? ");
        string answer = Console.ReadLine();
        guess = int.Parse(answer);

        if (guess < magicNumber)
        {
            Console.WriteLine("Higher");
        }

        else if (guess > magicNumber)
        {
            Console.WriteLine("Lower");
        }

        else
        {
            Console.WriteLine("You guessed it!");
        }
}



    }
}