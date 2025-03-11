using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer"; 
        job1._company = "Microsoft";
        job1._startYear = 1975;
        job1._endYear = 2000;

        Job job2 = new Job();
        job2._jobTitle = "Ship Capitan"; 
        job2._company = "East India Company";
        job2._startYear = 1600;
        job2._endYear = 1874;

        Resume resume = new Resume();
        resume._name = "Glup Shitto";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.DisplayResume();
    }
}