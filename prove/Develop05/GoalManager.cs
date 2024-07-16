using System.Security.Cryptography.X509Certificates;

public class GoalManager
{
    private List<Goal>_goals;
    private int _score;
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }
    public List<Goal> GetGoals()
    {
        return _goals;
    }
    public void Start()
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Goal Manager");
            Console.WriteLine("1. Display Player Information");
            Console.WriteLine("2. List Goal Names");
            Console.WriteLine("3. List Goal Details");
            Console.WriteLine("4. Create Goal");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Save Goals");
            Console.WriteLine("7. Load Goals");
            Console.WriteLine("8. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    DisplayPlayerInformation();
                    break;
                case "2":
                    ListGoalNames();
                    break;
                case "3":
                    ListGoalDetails();
                    break;
                    case "4":
                    CreateGoal();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    SaveGoals();
                    break;
                case "7":
                    LoadGoals();
                    break;
                case "8":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
            Console.WriteLine();
        }
    }
    public void DisplayPlayerInformation()
    {
        Console.WriteLine($"You have {_score} points");
         

    }
    public void ListGoalNames()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i+1}. {_goals[i].GetShortName()}");
        }

    }
    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetStringRepresentation());
        }

    }
    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are:\n");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Checklist Goal");
        Console.WriteLine("3. Eternal Goal");
        Console.Write("Chose the type of goal to create ");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("Enter name of your goal: ");
        string _shortName = Console.ReadLine();
        Console.Write("Enter the description of your goal: ");
        string _description = Console.ReadLine();
        
        

        if (choice == 1)
        {
            Console.Write("Enter the points you wish for this goal: ");
            int _points = int.Parse(Console.ReadLine());
            SimpleGoal simpleGoal = new SimpleGoal(_shortName, _description, _points);
            _goals.Add(simpleGoal);
        }
        else if (choice == 2)
        {
            Console.Write("Enter the base points you wish for this goal: ");
            int _points = int.Parse(Console.ReadLine());
            Console.Write("How mant times must you attend this goal to get a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for attending it that times? ");
            int bonus = int.Parse(Console.ReadLine()); 
            ChecklistGoal checklistGoal = new ChecklistGoal(_shortName, _description, _points, target, bonus);
            _goals.Add(checklistGoal);
        }
        else if (choice == 3)
        {
            Console.Write("Enter the points to get every time you do it: ");
            int _points = int.Parse(Console.ReadLine());
            EternalGoal eternalGoal = new EternalGoal(_shortName, _description, _points);
            _goals.Add(eternalGoal);
        }   
    }
    public void RecordEvent()
    {

        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
        }
        Console.Write("Which goal did you accomplish? ");
        int accomplish = int.Parse(Console.ReadLine()) - 1;
        if (accomplish >= 0 && accomplish < _goals.Count)
        {
            Goal goal = _goals[accomplish];
            goal.RecordEvent();
            _score += goal.GetPoints();

            if (goal is ChecklistGoal checklistGoal && checklistGoal.IsComplete())
            {
                _score += checklistGoal.GetBonus();
                DisplayCongratulatoryMessage();
            }
        }
    }      
            
       
    
    public void SaveGoals()
    {
        Console.Write("Enter a file name to save your information: ");
        string fileName = Console.ReadLine();
        using (StreamWriter outPutFile = new StreamWriter(fileName))
        {
            foreach (Goal goal in _goals)
            {
                outPutFile.WriteLine(goal.GetStringRepresentation());
            }
        }


    }
   public void LoadGoals()
{
    Console.Write("Enter file name to load from: ");
    string fileName = Console.ReadLine();

    try
    {
        string[] lines = File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            string[] data = line.Split("|");  // Adjust delimiter as needed

            if (data.Length >= 4)
            {
                string goalType = data[0].Trim();
                string shortName = data[1].Trim();
                string description = data[2].Trim();
                if (int.TryParse(data[3].Trim(), out int points))
                {
                    switch (goalType)
                    {
                        case "[✓]": // Example for SimpleGoal, adjust based on your output format
                            _goals.Add(new SimpleGoal(shortName, description, points));
                            break;
                        case "[ ]": // Example for EternalGoal, adjust based on your output format
                            _goals.Add(new EternalGoal(shortName, description, points));
                            break;
                        // Add cases for other types of goals as needed
                        default:
                            Console.WriteLine($"Unknown goal type: {goalType}. Skipping.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine($"Invalid points format: {data[3]}. Skipping.");
                }
            }
            else
            {
                Console.WriteLine($"Invalid data format: {line}. Skipping.");
            }
        }

        Console.WriteLine("Goals loaded successfully.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error loading goals: {ex.Message}");
    }
    
}
 public void DisplayCongratulatoryMessage()
    {
        string message = "Congratulations! You've completed the goal and earned a bonus!";
        string[] animationFrames = new string[]
        {
            ".",
            "..",
            "...",
            "....",
            ".....",
            "......",
            ".......",
            "........",
            ".........",
            "..........",
            "...........",
            "............",
            "%%%%%%%%%%%%%%%%%%%%%%%%",
            "***************************************************",
            
        };

        foreach (string frame in animationFrames)
        {
            
            Console.WriteLine(frame);
            Thread.Sleep(500); // Adjust delay for animation speed
        }

        Console.Clear();
        Console.WriteLine(message);
    }
}
 

