class Breathing : Activity
{
    public Breathing() : base("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", "Breathing")
    {
    }
    public void Breath()
    {
        //Runs the Breathing activity
        DisplayWelcome();
        DateTime stopTime = DateTime.Now.AddSeconds(GetTime());
        while (DateTime.Now < stopTime)
        {
            Console.WriteLine();
            Console.Write("Breathe in...");
            PauseAnimation("countdown", 6);
            Console.WriteLine();
            Console.Write("Now breathe out...");
            PauseAnimation("countdown", 4);
            Console.WriteLine();
        }
        DisplayGoodbye();
    }
}