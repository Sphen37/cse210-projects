
using System.Runtime.InteropServices;

class Entry
{
    public string _date = "";
    public string _prompt = "";
    public string _response = "";
    

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}\n{_response}");
    }
    public string WriteDisplay()
    {
        return $"{_date},\"{_prompt}\",\"{_response}\"";
    }
    public string RandomPrompt()
    {
        Random _randomPrompt = new Random();
        int _randomizer = _randomPrompt.Next(0,7);
        List<string> _prompts = ["Who was the most interesting person I interacted with today?", "What brought you joy today?", "How are you feeling today?", "How did you help someone else today?", "What was the best part of my day?", "If I had one thing I could do over today, what would it be?", "What is the meaning of existance?", "What are you doing with your life right now?"];
        string _newPrompt = _prompts[_randomizer];
        return _newPrompt = _prompts[_randomizer];

    }
}