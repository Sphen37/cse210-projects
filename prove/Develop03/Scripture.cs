using Microsoft.Win32.SafeHandles;

class Scripture
{
    private Words _words;
    private Reference _reference;
    public Scripture()
    {
        //Initializes a new Scripture class if the user doesn't want anything in it.
        _words = new Words("And he shall go forth, suffering pains and afflictions and temptations of every kind; and this that the word might be fulfilled which saith he will take upon him the pains and the sicknesses of his people. And he will take upon him death, that he may loose the bands of death which bind his people; and he will take upon him their infirmities, that his bowels may be filled with mercy, according to the flesh, that he may know according to the flesh how to succor his people according to their infirmities.");
        _reference = new Reference();
    }
    public Scripture(string words, string book, int chapter, int firstVerse, int lastVerse)
    {
        //Initializes a new scripture class with user inputs that have multiple verses.
        _words = new Words(words);
        _reference = new Reference(book, chapter, firstVerse, lastVerse);
    }
    public Scripture(string words, string book, int chapter, int firstVerse)
    {
        //Initializes a new scripture class with user inputs that only have one verse.
        _words = new Words(words);
        _reference = new Reference(book, chapter, firstVerse);
    }
    public void Display()
    {
        //Displays both the reference and words to it in a neat fashion.
        Console.WriteLine($"{_reference.GetReference()} {_words.GetWords()}");
    }
    public int GetChoice()
    {
        //Allows the user to choose if they want to memorize the builtin scripture or add their own.
        //Returns the answer as an integar
        //Adding their own scripture is part of my exceeding requirements goal.
        Console.Clear();
        Console.WriteLine("1: Memorize Starter Scripture");
        Console.WriteLine("2: Add my own Scipture");
        Console.WriteLine("3: Quit");
        Console.Write("What would you like to do: " );
        return int.Parse(Console.ReadLine());
    }
    public void SetScripture()
    {
        //Sets both reference and words so that a user can input their own scripture if they want.
        //All of this is part of my exceeding requirements goal.
        _reference.SetReference();
        _words.SetWords();
    }
    public void Hide()
    {
        //Pulls up the scripture both reference and words to it
        string quit = "";
        bool hidden = false;
        while (!hidden)
        {   
            //Will continue running this until the user either types quit or every word in the scripture is hidden and they press enter.
            hidden = _words.GetIsHidden();
            Console.Clear();
            Display();
            _words.HideWords();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            quit = Console.ReadLine();
            if (quit.ToLower() == "quit")
            {
                hidden = !hidden;
            }
        }
        
    }
}