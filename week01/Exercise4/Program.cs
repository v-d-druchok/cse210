using System;
using System.Dynamic;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        List<int> numbers = new List<int>();

        int number = 0;

        int sum = 0;

        int biggest = 0;

        do{
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            number = int.Parse(input);

            if (number != 0)
            {    
                numbers.Add(number);
            }

        } while (number != 0);


        foreach (int num in numbers)
        {
            sum += num;

            if (num > biggest)
            {
                biggest = num;
            }
        }
        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        Console.WriteLine($"The largest number is: {biggest}");
    }
}