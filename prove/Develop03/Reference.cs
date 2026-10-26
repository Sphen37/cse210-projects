using System.ComponentModel;

class Reference
{
    private string _book;
    private int _chapter;
    private int _firstVerse;
    private int _lastVerse;
    public Reference()
    {
        //Initalizes with the base scripture pre-built into the program.
        _book = "Alma";
        _chapter = 7;
        _firstVerse = 11;
        _lastVerse = 12;
    }
    public Reference(string book, int chapter, int firstVerse, int lastVerse)
    {
        //Allows the class to initialize with all the variables changed.
        _book = book;
        _chapter = chapter;
        _firstVerse = firstVerse;
        _lastVerse = lastVerse;
    }   
    public Reference(string book, int chapter, int firstVerse)
    {
        //Allows the class to initialize if the user only has one verse instead of multiple.
        _book = book;
        _chapter = chapter;
        _firstVerse = firstVerse;
        _lastVerse = 0;
    }
    public string GetReference()
    {
        //Returns the reference as a string depending on if it has a last verse or not.
        if (_lastVerse == 0)
        {
            return $"{_book} {_chapter}:{_firstVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_firstVerse}-{_lastVerse}";
        }
    }
    public void SetReference()
    //All of this is part of my exceeding requirements goal.
    {
        //Allows the user to set the information in the class themselves if they want to add their own scripture.
        Console.Write("What's the book heading (i.e. 2 Nephi): ");
        _book = Console.ReadLine();
        Console.Write("What chapter is it: ");
        _chapter = int.Parse(Console.ReadLine());
        bool _multiple = true;
        //Makes sure the user inputs either y for multiple verses or n for only one verse.
        while (_multiple)
        {
            Console.Write("Do you have multiple verses (y/n): ");
            string multipleVerses = Console.ReadLine();
            if (multipleVerses.ToLower() == "y")
            {
                //If the user has multiple verses it will prompt them to input the starting verse and ending verse.
                Console.Write("What is the number for the starting verse: ");
                _firstVerse = int.Parse(Console.ReadLine());
                Console.Write("What is the number for the last verse: ");
                _lastVerse = int.Parse(Console.ReadLine());
                _multiple = !_multiple;
            }
            else if (multipleVerses.ToLower() == "n")
            {
                //If the user has only one verse it will prompt them for that verse.
                Console.Write("What is the number to the verse: ");
                _firstVerse = int.Parse(Console.ReadLine());
                _lastVerse = 0;
                _multiple= !_multiple;
            }
        }
    }
}