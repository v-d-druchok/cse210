using System;

class Program
{
    static void Main(string[] args)
    {   
        Console.Clear();

        List<Activity> activities = new List<Activity>();

        Running running = new Running("6 June 1944", 45, 5);
        activities.Add(running);

        Bicycle cycling = new Bicycle("8 Aug 1984", 120, 15);
        activities.Add(cycling);

        Swimming swimming = new Swimming("14 Apr 2025", 60, 40);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}