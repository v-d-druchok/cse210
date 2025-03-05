using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your course grade? ");
        string userGrade = Console.ReadLine();

        int grade = int.Parse(userGrade);

        string lGrade = "";

        if (grade >= 90)
        {
            lGrade = "A";
        }
        
        else if (grade >= 80 && grade < 90)
        {
            lGrade = "B";
        }

        else if (grade >= 70 && grade < 80)
        {
            lGrade = "C";
        }

        else if (grade >= 60 && grade < 70)
        {
            lGrade = "D";
        }

        else
        {
            lGrade = "F";
        }

        Console.WriteLine($"Your grade for the course is {lGrade}.");

        if (grade >= 70)
        {
            Console.WriteLine("Cangradulations you have made the passing grade for the course!");
        }

        else
        {
            Console.WriteLine("You have failed to meet the requierments to pass the course, better luck next time.");
        }
    }
}