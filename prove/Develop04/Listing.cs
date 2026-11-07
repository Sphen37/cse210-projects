class Listing : Activity
{
    private List<string> _prompt;
    private List<string> _responses;
    public Listing() : base("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", "Listing")
    {
        //Sets the the lists to their basic configuration
        _prompt = ["Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"];
        _responses = [];
    }
    public void List()
    {
        //Runs the Listing activity
        DisplayWelcome();
        Random random = new();
        int randomNum = random.Next(0, _prompt.Count);
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {_prompt[randomNum]} ---");
        Console.Write("You may begin in: ");
        PauseAnimation("countdown", 5);
        Console.WriteLine();
        DateTime stopTime = DateTime.Now.AddSeconds(GetTime());
        while (DateTime.Now < stopTime)
        {
            //This stores the responses in a list so they can be counted later
            Console.Write("-> ");
            _responses.Add(Console.ReadLine());
        }
        //Displays the amount of items listed by the user
        Console.WriteLine($"You listed {_responses.Count} items!");
        //This removes prompts so that they are only reused once all prompts have been used
        //This is part of my exceeding creativity.
        _prompt.Remove(_prompt[randomNum]);
        if (_prompt.Count == 0)
        {
            //Resets the prompt list in case it runs out of prompts
            _prompt = ["Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"];
        }
        _responses = [];
        DisplayGoodbye();
    }
}