using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquaredNumber(userNumber);

        DisplayResult(userName, squaredNumber);

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string answer = Console.ReadLine();
            int number = int.Parse(answer);
            return number;
        }

        static int SquaredNumber(int number)
        {
            int square = number * number;
            return square;
        }

        static void DisplayResult(string name, int square)
        {
        Console.WriteLine($"{name}, the square of your number is {square}");
        }
    }
}