using System.Formats.Tar;

public class GoalManager
{
    private int _score;
    private List<Goal> _goals = new List<Goal>();

    public GoalManager()
    {
        _score = 0;
    }

    public void Start()
    {

        bool done = false;

        do
        {
            DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            String response = Console.ReadLine();

            if (response == "1")
            {
                CreateGoal();
            }
            else if (response == "2")
            {
                ListGoalDetails();
            }
            else if (response == "3")
            {
                SaveGoals();
            }
            else if (response == "4")
            {
                LoadGoals();
            }
            else if(response == "5")
            {
                RecordEvent();
            }
            else if (response == "6")
            {
                done = true;
            }
        } while(!done);

    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} Shards.");
    }
    public void ListGoalNames()
    {
        int count = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{count}. {goal.GetName()}");
        }

    }
    public void ListGoalDetails()
    {
        int count = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{count}. {goal.GetDetailsString()}");
        }

    }
    public void CreateGoal()
    {
        Console.WriteLine();
        Console.WriteLine("What kind of Goal do you want to make?");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        String response = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("What is the name of the Goal? ");
        String name = Console.ReadLine();
        Console.WriteLine("Describe your goal. ");
        String description = Console.ReadLine();
        Console.WriteLine("How many Shards will you get for completing this goal? ");
        String shards = Console.ReadLine();
        shards = StringToIntCheck(shards).ToString();

        if (response == "1")
        {
            SimpleGoal newgoal = new SimpleGoal(name, description, shards);
        }
        else if (response == "2")
        {
            EternalGoal newgoal = new EternalGoal(name, description, shards);
        }
        else if (response == "3")
        {
            Console.WriteLine("How many times do you want to do this goal? ");
            String target = Console.ReadLine();
            int targetInt = StringToIntCheck(target);
            Console.WriteLine("How many bounus shards do you want to get for reaching your target? ");
            String bonus = Console.ReadLine();
            int bonusInt = StringToIntCheck(bonus);

            ChecklistGoal newGoal = new ChecklistGoal(name, description, shards, targetInt, bonusInt);
        }

    }
    public void RecordEvent()
    {
        Console.WriteLine("Select you Goal:");
        ListGoalNames();
        int numberOfGoals = _goals.Count;
        Console.Write($"Enter a number between 1 and {numberOfGoals}: ");
        String response = Console.ReadLine();
        int responseInt = StringToIntCheck(response);
        if (responseInt > 0 && responseInt < numberOfGoals)
        {
            int index = responseInt - 1;
            _goals[index].RecordEvent();
        }
        else
        {
            Console.WriteLine("ERROR: number entered does not exist!");
        }

    }
    public void SaveGoals()
    {
        Console.WriteLine("Please enter a file name: ");
        String filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
    public void LoadGoals()
    {
        Console.WriteLine("Please enter a file name: ");
        String filename = Console.ReadLine();
        String[] lines = System.IO.File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);
        
        foreach (String line in lines)
        {
            String[] parts = line.Split(":");
            String goalType = parts[0];
            String[] goalStrings = parts[1].Split("~");


            if (goalType.Equals("SimpleGoal"))
            {
                SimpleGoal newgoal = new SimpleGoal(goalStrings[0], goalStrings[1], goalStrings[2]);
                _goals.Add(newgoal);
            }
            else if (goalType.Equals("EternalGoal"))
            {
                EternalGoal newgoal = new EternalGoal(goalStrings[0], goalStrings[1], goalStrings[2]);
                _goals.Add(newgoal);
            }
            else if (goalType.Equals("ChecklistGoal"))
            {
                ChecklistGoal newgoal = new ChecklistGoal(goalStrings[0], goalStrings[1], goalStrings[2], int.Parse(goalStrings[3]), int.Parse(goalStrings[4]));
            }
            else
            {
                Console.WriteLine("ERROR!!! GOAL NOT FOUND!");
            }
        }
    }

    private int StringToIntCheck(String number)
    {
        bool pass = true;
        int numberInt = -1;
        do
        {
            try
            {
                if (pass == false)
                {
                    Console.WriteLine("Please enter a valid number: ");
                    number = Console.ReadLine();
                }
                numberInt = StringToIntCheck(number);
                pass = true;
            }
            catch (Exception)
            {
                Console.WriteLine($"The value {number} is not a valid number!");
                pass = false;
            }

        } while (!pass);

        return numberInt;
    }
}