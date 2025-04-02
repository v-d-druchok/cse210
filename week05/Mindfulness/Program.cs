using System;
using System.ComponentModel.Design;
// Showing Creativity and Exceeding Requirements:   
// Made the spinner go at 60 fps while dealing with any potential delays while displaying it in the console.
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        string select = "";

        while(select != "4")
        {
            Console.WriteLine();
            Console.WriteLine("Main Menu:");

            Console.WriteLine(" 1. Breathing activity");
            Console.WriteLine(" 2. Reflecting activity");
            Console.WriteLine(" 3. Listing activity");
            Console.WriteLine(" 4. Quit");

            Console.Write("Enter a number to select: ");
            select = Console.ReadLine();

            if (select == "1")
            {
                BreathingActivity act1 = new BreathingActivity();

                act1.Run();

                Console.Clear();
            }

            else if (select == "2")
            {
                ReflectionActivity act2 = new ReflectionActivity();

                act2.Run();

                Console.Clear();
            }

            else if (select == "3")
            {
                ListingActivity act3 = new ListingActivity();

                act3.Run();

                Console.Clear();
            }

            else if (select == "4")
            {
                
            }

            else 
            {
                Console.WriteLine();
                Console.WriteLine("Invalid, please enter a number that is an option in the menu.");
            }
        }
    }
}