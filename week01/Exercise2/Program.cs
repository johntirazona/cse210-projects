using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade in perecentage? ");
        string grade = Console.ReadLine();

        int gradeValue = int.Parse(grade);

        string letter = "";

        if (gradeValue >= 90)
        {
            letter = "A";
        }

        else if (gradeValue >= 80)
        {
            letter = "B";
        }

        else if (gradeValue >= 70)
        {
            letter = "C";
        }

        else if (gradeValue >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is '{letter}'.");

        if (gradeValue >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }

        else
        {
            Console.WriteLine("Sorry you failed.");
        }
    }
}