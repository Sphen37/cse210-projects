
using System.Runtime.InteropServices;

class Entry
{
    //all the public attributes of the Entry Class
    public string _date = "";
    public string _prompt = "";
    public string _response = "";
    //all the public methods of the Entry Class
    public void Display()
    {
        //Displays the Entry Class information in the proper format
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}\n{_response}");
    }
    public string WriteDisplay()
    {
        //Writes the display information as a string so that it can be saved properly.
        return $"{_date},\"{_prompt}\",\"{_response}\"";
    }
    public string RandomPrompt()
    {
        //Randomizes the prompt for the user each time they want to write a new entry
        Random _randomPrompt = new Random();
        int _randomizer = _randomPrompt.Next(0,7);
        List<string> _prompts = ["Who was the most interesting person I interacted with today?", "What brought you joy today?", "How are you feeling today?", "How did you help someone else today?", "What was the best part of my day?", "If I had one thing I could do over today, what would it be?", "What is the meaning of existance?", "What are you doing with your life right now?"];
        string _newPrompt = _prompts[_randomizer];
        return _newPrompt = _prompts[_randomizer];
    }
}