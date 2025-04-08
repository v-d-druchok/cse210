public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amount) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amount;
    }

    public override void RecordEvent()
    {
        _amountCompleted += 1;
        Console.WriteLine($"I applaud!! You have advanced yourself {GetPoints()} points, by once again sticking to your goal!");
        
        if(_amountCompleted == _target)
        {
            ConfettiAnimation(3);
            Console.WriteLine();

            DisplayCongrats();

            Console.WriteLine();
            ConfettiAnimation(3);

            Console.WriteLine();
            Console.WriteLine($"You earned a bonus of {_bonus} points for completing this task the set amount of times!");
        }
    }

    public override bool IsComplete()
    {
        if(_amountCompleted == _target)
        {
            return true;
        }

        else
        {
            return false;
        }
    }

    public override string GetDetailsString()
    {   
       return $"{GetName()} ({GetDescription()}) -- Progress: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal-_-{GetName()}-_-{GetDescription()}-_-{GetPoints()}-_-{_bonus}-_-{_target}-_-{_amountCompleted}";
    }

    public void DisplayCongrats()
    {
        List<string> message = new List<string>
        {
            " 888   88 88888888 888  888   ,dbPPPp   ,d8PPPP     888888888 888  888   ,d8PPPP     d88PPPo   ,d8PPPP 88888888  888888888 ",
            "888ooo88 888  888 888  888   d88ooP'   d88ooo         '88d   88888888   d88ooo      888ooo8   d88ooo  88ooooPp     '88d    ",
            "      88 888  888 888  888 ,88' P'   ,88'            '888    88P  888 ,88'          888   8 ,88'             d8   '888     ",
            "PPPPPP8P 888oo888 888PP888 88  do    88bdPPP       '88p      88P  888 88bdPPP       888PPPP 88bdPPP   8888888P  '88p       ",

        };
        
        foreach (string line in message)
        {
            Console.WriteLine(line);
        }
    }

    public void ConfettiAnimation(int sec)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(sec);

        while (DateTime.Now < endTime)
        {
            List<string> animationStrings = new List<string>
            {
                ".     /       *       \\       .       *     /",
                "/     .       /       *       \\       .     *"
            };

            foreach (string s in animationStrings)
            {
                Console.Write(s);
                Thread.Sleep(500);
                Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
            }
        }
    }

}