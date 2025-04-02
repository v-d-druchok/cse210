public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>()
    {
    "Who are the things in life that you most appreciate?",

    "What are your biggest personal strngths?",

    "Who are the people that you have helped this week?",

    "When have you felt compelled to do today",

    "Who are your personal heroes and sourses of inspiration?"
    };

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }
    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine();
        Console.WriteLine("Try to get as many responses to the following question as you can.");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine();
        Console.WriteLine("Prepare thyself…");
        ShowSpinner(3);

        Console.WriteLine();
        GetListFromUser();
        Console.WriteLine();

        DisplayEndingMessage();
    } 

    public string GetRandomPrompt()
    {   
        Random random = new Random();
        int index = random.Next(_prompts.Count);

        return _prompts[index];
    }
 
    public List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while(DateTime.Now < endTime)
        {
        Console.Write(">>>");
        responses.Add(Console.ReadLine());
        }

        _count = responses.Count();

        Console.WriteLine($"You have listed {_count} items!");

        return responses;
    }
}