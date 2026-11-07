using System.Transactions;

class Activity
{
    private string _welcome;
    private string _name;
    private int _totalTime;
    private int _stopTime;
    public Activity(string welcome, string name)
    {
        _welcome = welcome;
        _name = name;
        _totalTime = 0;
    }
    protected void DisplayWelcome()
    {
        //Displays the welcome information
        int time = 0;
        while (time == 0)
        {
            Console.Clear();
            Console.WriteLine($"Welcome to the {_name} Activity");
            Console.WriteLine();
            Console.WriteLine(_welcome);
            Console.WriteLine();
            Console.Write("How long, in seconds, would you like for your session? ");
            if (int.TryParse(Console.ReadLine(), out time))
            {
                if (time != 0)
                {
                    //Sets _totalTime to time which stores time in a tracker for total amount of time spent in an activity.
                    _totalTime += time;
                    //Sets _stopTIme to time which stores the time just for the current activity being run.
                    _stopTime = time;
                    Console.Clear();
                    Console.WriteLine("Get ready...");
                    PauseAnimation("spinner", 5);
                }
                else
                {
                    Console.WriteLine("Please input a number greater than 0.");
                    PauseAnimation("spinner", 2);
                }
            }
        }
    }
    protected int GetTime()
    {
        //returns the time so activities can be run for the set time. 
        return _stopTime;
    }
    protected void DisplayGoodbye()
    {
        //Displays common goodbye message for all games and 
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        PauseAnimation("spinner", 5);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_stopTime} seconds of the {_name} Activity.");
        PauseAnimation("spinner", 5);
    }
    protected void PauseAnimation(string type, int time)
    {
        //If they input spinner it will cause a spinner animation to run based on how much time they want
        if (type == "spinner")
        {
            DateTime stopTime = DateTime.Now.AddSeconds(time);
            List<string> animation = ["|","/","-","\\"];
            int i = 0;
            while(DateTime.Now < stopTime)
            {
                string s = animation[i];
                Console.Write(s);
                Thread.Sleep(250);
                Console.Write("\b \b");
                i++;
                if(i >= animation.Count)
                {
                    i = 0;
                }
            }
        }
        //If they input countdown it will cause a countdown to start from the time they inputted
        else if (type == "countdown")
        {
            for (int i = time; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
    }
    public void TimeStats()
    {
        //This is part of my exceeding requirements
        //Displays the total amount of time an activity has been run for in a session
        Console.WriteLine($"You have completed a total of {_totalTime} seconds in the {_name} Activity during this session.");
    }
}