using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = PromptUserName();
        int favNum = PromptUserNumber();

        int squareNumber = SquareNumber(favNum);

        DisplayResult(name, squareNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: : ");
        string number = Console.ReadLine();
        int favNum = int.Parse(number);

        return favNum;
    }

    static int SquareNumber(int favNum)
    {
        int squareNumber = favNum * favNum;

        return squareNumber;
    }

    static void DisplayResult(string name, int squareNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squareNumber}");
    }

}