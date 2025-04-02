using System;
using System.Diagnostics;
using System.Threading;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
        _name = "N/A";
        _description = "N/A";
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Hello and welcome to the {_name}");
        Console.WriteLine($"\n{_description}");
        Console.WriteLine("\nHow many seconds would you like the activity to last: ");
        string duration = Console.ReadLine();
        _duration = int.Parse(duration);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Great Job!");
        Console.WriteLine($"You have manged to do the {_name} for a whole {_duration} seconds this time.");
        ShowSpinner(5);
    }

    public void ShowSpinner(int secs)
    {
        string[] spinnerFrames = { "|", "/", "-", "\\" };
        int frameIndex = 0;
        int totalTime = secs * 1000;
        int mspf = 16; //stands for milliseconds per frame
        
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        while (stopwatch.ElapsedMilliseconds < totalTime)
        {
            Console.Write(spinnerFrames[frameIndex]);
            
            long frameStart = stopwatch.ElapsedMilliseconds;
            Thread.Sleep(mspf);
            long frameEnd = stopwatch.ElapsedMilliseconds;

            Console.Write("\b \b");

            frameIndex = (frameIndex + 1) % spinnerFrames.Length;

            
            int actualFrameTime = (int)(frameEnd - frameStart);
            int timeCorrection = mspf - actualFrameTime;
            
            if (timeCorrection > 0)
            {
                Thread.Sleep(timeCorrection);
            }
        }

        stopwatch.Stop();
    }
    public void ShowCountDown(int sec)
    {   

        while(sec > 0)
        {   
            Console.Write(sec);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            
            sec -= 1;
        } 
    }

}