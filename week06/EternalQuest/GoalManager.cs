using System.IO;
public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        Console.Clear();
        string choice = "";

       while (choice != "6")
       {    

            DisplayPlayerInfo();

            Console.WriteLine("\nMain Menu:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.WriteLine("Type number to select:");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                CreateGoal();
            }

            else if (choice == "2")
            {
                ListGoalDetails();
            }

            else if (choice == "3")
            {
                SaveGoals();
            }

            else if (choice == "4")
            {
                LoadGoals();
            }

            else if (choice == "5")
            {
                RecordEvent();
            }

            else
            {
                Console.WriteLine();
                Console.WriteLine("Invalid input. Please select a number from the menu.");
            }
       }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have a total of {_score} points.");
    }

    public void ListGoalNames()
    {   
        int i = 1;

        Console.WriteLine();
        Console.WriteLine("Your current goals are:");
        Console.WriteLine();

        foreach(Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetName()}");
            i += 1;
        }
    }
    
    public void ListGoalDetails()
    {
        int i = 1;

        Console.WriteLine();
        Console.WriteLine("Your current goals are:");
        Console.WriteLine();

         foreach (Goal goal in _goals)
        {
            if (goal.IsComplete())
            {
                Console.WriteLine($"{i}. [X] {goal.GetDetailsString()}");
                i += 1;
            }

            else
            {
                Console.WriteLine($"{i}. [ ] {goal.GetDetailsString()}");
                i += 1;
            }
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine();
        Console.WriteLine("the types of goals are:");
        Console.WriteLine();

        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Cheklist Goal");

        Console.WriteLine("\nWhich type of goal do you want to create?");
        string goal = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("whats the name of your goal?");
        string name = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("What is a short description of it?");
        string description = Console.ReadLine();
        
        Console.WriteLine();
        Console.WriteLine("How many points do you earn upon completion?");
        string p = Console.ReadLine();
        int points = int.Parse(p);

        if (goal == "1")
        {   
            SimpleGoal g1 = new SimpleGoal(name, description, points);
            _goals.Add(g1);
        }

        else if (goal == "2")
        {
            EternalGoal g2 = new EternalGoal(name, description, points);
            _goals.Add(g2);
        }

        else if (goal == "3")
        {
            Console.WriteLine();
            Console.WriteLine("How many times do you want to preform this goal?");
            string t = Console.ReadLine();
            int target = int.Parse(t);

            Console.WriteLine();
            Console.WriteLine("How many bonus points do you earn upon completig the goal that many times?");
            string b = Console.ReadLine();
            int bonus = int.Parse(b);

            ChecklistGoal g3 = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(g3);
        }
    }

    public void RecordEvent()
    {
        ListGoalNames();

        Console.WriteLine();
        Console.Write("Which of these goals did you accomplish? ");
        int i = int.Parse(Console.ReadLine()) - 1;

        _goals[i].RecordEvent();
        _score += _goals[i].GetPoints();

        Console.WriteLine();
        Console.WriteLine($"You now have {_score} points!");
    }

    public void SaveGoals()
    {   
        Console.WriteLine();
        Console.Write("Please enter the name of the file you want to save your goals to (without file format): ");
        string filename = $"{Console.ReadLine()}.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);

            foreach (Goal g in _goals)
            {
                outputFile.WriteLine(g.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.WriteLine();
        Console.Write("Please enter filename (without file format): ");
        string filename = $"{Console.ReadLine()}.txt";

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("-_-");

            if (parts[0] == "SimpleGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                bool completion = Convert.ToBoolean(parts[4]);

                SimpleGoal simple = new SimpleGoal(name, description, points, completion);
                _goals.Add(simple);
            }

            else if (parts[0] == "EternalGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                EternalGoal eternal = new EternalGoal(name, description, points);
                _goals.Add(eternal);
            }

            else if (parts[0] == "ChecklistGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                int bonus = int.Parse(parts[4]);
                int target = int.Parse(parts[5]);
                int completed = int.Parse(parts[6]);

                ChecklistGoal checklist = new ChecklistGoal(name, description, points, target, bonus, completed);
                _goals.Add(checklist);
            }

            else
            {
                _score = int.Parse(parts[0]);
            }
        }
    }
}