using System.Formats.Tar;

public class GoalManager
{

    /******************************************************************************
    Added a part to this program for the exceeds expectionatons that will check to
    see if the goal is already complete. If so it will tell you and not reward you.
    ******************************************************************************/
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
            else 
            {
                Console.WriteLine($"Invaled response: {response}.");
            }
        } while(!done);

    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} Shards.");
    }
    public void ListGoalNames()
    {
        Console.WriteLine();
        int count = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{count}. {goal.GetName()}");
            count++;
        }

    }
    public void ListGoalDetails()
    {
        Console.WriteLine();
        int count = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{count}. {goal.GetDetailsString()}");
            count++;
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
            SimpleGoal newGoal = new SimpleGoal(name, description, shards);
            _goals.Add(newGoal);
        }
        else if (response == "2")
        {
            EternalGoal newGoal = new EternalGoal(name, description, shards);
            _goals.Add(newGoal);
        }
        else if (response == "3")
        {
            Console.WriteLine("How many times do you want to do this goal? ");
            String target = Console.ReadLine();
            int targetInt = StringToIntCheck(target);
            Console.WriteLine("How many bounus shards do you want to get for reaching your target? ");
            String bonus = Console.ReadLine();
            int bonusInt = StringToIntCheck(bonus);

            ChecklistGoal newGoal = new ChecklistGoal(name, description, shards, targetInt, 0, bonusInt);
            _goals.Add(newGoal);
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
        if (responseInt > 0 && responseInt <= numberOfGoals)
        {
            int index = responseInt - 1;
            if (_goals[index].IsComplete())
            {
                Console.WriteLine("You have already finished this goal.");
            }
            else
            {
                _goals[index].RecordEvent();
                _score += int.Parse(_goals[index].GetShards());
            }
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
        String[] lines;
        try
        {
            lines = System.IO.File.ReadAllLines(filename);
            _score = int.Parse(lines[0]);
            foreach (String line in lines.Skip(1))
            {
                String[] parts = line.Split(":");
                String goalType = parts[0];
                String[] goalStrings = parts[1].Split("~");


                if (goalType.Equals("SimpleGoal"))
                {
                    SimpleGoal newGoal = new SimpleGoal(goalStrings[0], goalStrings[1], goalStrings[2]);
                    bool compete = bool.Parse(goalStrings[3]);
                    newGoal.SetComplete(compete);
                    _goals.Add(newGoal);
                }
                else if (goalType.Equals("EternalGoal"))
                {
                    EternalGoal newGoal = new EternalGoal(goalStrings[0], goalStrings[1], goalStrings[2]);
                    _goals.Add(newGoal);
                }
                else if (goalType.Equals("ChecklistGoal"))
                {
                    ChecklistGoal newGoal = new ChecklistGoal(goalStrings[0], goalStrings[1], goalStrings[2], int.Parse(goalStrings[4]), int.Parse(goalStrings[3]), int.Parse(goalStrings[5]));
                    _goals.Add(newGoal);
                }
                else
                {
                    Console.WriteLine("ERROR!!! GOAL NOT FOUND!");
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found.");
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
                numberInt = int.Parse(number);
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