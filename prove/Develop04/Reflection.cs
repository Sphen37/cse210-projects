using System.Diagnostics;

class Reflection : Activity
{
    private List<string> _prompt;
    private List<string> _questions;
    public Reflection() : base("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", "Reflection")
    {
        //Sets the lists to their basic configuration
        _prompt = ["Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."];
        _questions = ["Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"];
    }
    public void Reflect()
    {
        //Runs the Reflection activity
        DisplayWelcome();
        //Selects a random prompt and displays it to the user
        Random random = new();
        int randomNum = random.Next(0, _prompt.Count);
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"--- {_prompt[randomNum]} ---");
        //Pauses the program until the user has pressed enter
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they are related to this experience.");
        Console.Write("You may begin in: ");
        PauseAnimation("countdown", 5);
        Console.Clear();
        //This is part of my Exceeding requirements
        //It removes a prompt so it won't be used again until all prompts have been used or until they rerun the program
        _prompt.Remove(_prompt[randomNum]);
        if (_prompt.Count == 0)
        {
            //Resets the prompt list in case they run out of prompts
            _prompt = ["Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."];
        }
        DateTime stopTime = DateTime.Now.AddSeconds(GetTime());
        while (DateTime.Now < stopTime)
        {
            //This randomizes the questions that are asked
            randomNum = random.Next(0, _questions.Count);
            Console.Write($"-> {_questions[randomNum]}");
            PauseAnimation("spinner", 10);
            //This is part of my Exceeding requirements
            //It removes a question so it won't be used again until all questions have been used
            _questions.Remove(_questions[randomNum]);
            if (_questions.Count == 0)
            {
                //Resets the questions list in case it runs out of questions
                _questions = ["Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"];
            }
            Console.WriteLine();
        }
        DisplayGoodbye();
    }
}