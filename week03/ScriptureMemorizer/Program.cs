using System;
// Showing Creativity and Exceeding Requirements
// Made it so the program can only randomly select from those words that are not already hidden.
// Added ability to display hint at any time that goes away as soon as you don't need it

class Program
{
    static void Main(string[] args)
    {   
        Console.Clear();

        Random random = new Random();
        int numberToHide = random.Next(1, 4);

        Reference reference1 = new Reference("Ezekiel", 23, 19, 20);
        Scripture scripture1 = new Scripture(reference1, "Yet she multiplied her whoredoms, in calling to remembrance the days of her youth, wherein she had played the harlot in the land of Egypt. For she doted upon their paramours, whose flesh is as the flesh of asses, and whose issue is like the issue of horses.");
        Scripture unaltered = new Scripture(reference1, "Yet she multiplied her whoredoms, in calling to remembrance the days of her youth, wherein she had played the harlot in the land of Egypt. For she doted upon their paramours, whose flesh is as the flesh of asses, and whose issue is like the issue of horses.");
        string input = "";

        Console.WriteLine(scripture1.GetDisplayText());

        while (input != "quit")
        {
            Console.WriteLine("\nPress enter to continue or type hint to show hint (type quit to quit)");
            Console.Write(">>>");
            input = Console.ReadLine();

            if (!scripture1.IsCompletelyHidden() && input != "hint")
            {   
                Console.Clear();
                scripture1.HideRandomWords(numberToHide);
                Console.WriteLine(scripture1.GetDisplayText());
            }

            else if (input == "hint")
            {
                Console.WriteLine();
                Console.WriteLine(unaltered.GetDisplayText());
                Console.WriteLine("\nPress enter to hide hint");
            }


            else 
            {
                break;
            }
        }
    }
}