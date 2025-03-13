using System;
using System.ComponentModel;
using System.Net.Quic;

// Added the ability to add custom user prompts and load them from a file.
class Program
{
    static void Main(string[] args)
    {
        int choice = 0;

        PromptGenerator nuPrompt = new PromptGenerator();
        Journal journal = new Journal();

        while (choice != 5)
        {
            Console.WriteLine("\nPlease select one of the following:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Add Custom Prompt");
            Console.WriteLine("6. Quit");

            Console.Write("Input the corresponding number to select. ");
            string userChoise = Console.ReadLine();

            choice = int.Parse(userChoise);

            if (choice == 1)
            {
                Entry entry = new Entry();
                nuPrompt.SavePrompts();
                nuPrompt.LoadPrompts();
                string prompt = nuPrompt.GetRandomPrompt();

                Console.WriteLine(prompt);

                Console.Write(">>>");
                string response = Console.ReadLine();

                entry._entryText = response;
                entry._promptText = prompt;

                journal.AddEntry(entry);


            }

            else if (choice == 2)
            {
                journal.DisplayAll();
            }

            else if (choice == 3)
            {
                Console.WriteLine("Please input the name of the file you want to save your journal as: ");
                Console.Write(">>>");
                string file = Console.ReadLine();

                journal.Save(file);
            }

            else if (choice == 4)
            {
                Console.WriteLine("Please input the name of the file you want to load: ");
                Console.Write(">>>");
                string file = Console.ReadLine();

                journal.Load(file);
            }

            else if (choice == 5)
            {
                Console.WriteLine("Please input the custom prompt: ");
                Console.Write(">>>");
                string prompt = Console.ReadLine();

                nuPrompt.AddPrompt(prompt);

                nuPrompt.SavePrompts();
            }

            else if (choice == 6)
            {
                Console.WriteLine("See ya!");
            }

            else
            {
               Console.WriteLine("Please make a valid selection"); 
            }

        }
    }
}