using System.Security.Cryptography.X509Certificates;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine();
        Console.WriteLine("Prepare thyself…");
        ShowSpinner(5);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while(DateTime.Now < endTime)
        {
            Console.WriteLine("Inhale");
            Console.WriteLine();
            ShowCountDown(4);
            Console.WriteLine("Exhale");
            Console.WriteLine();
            ShowCountDown(4);
        }

        DisplayEndingMessage();
    }
    
}