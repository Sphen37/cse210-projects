class Journal
{
    //Creates all of the attributes for the Journal Class
    public List<Entry> _entries = [];
    public string _name = "";
    public string _text = "";
    //Creates all of the methods for the Journal Class
    public void DisplayEntry()
    {
        //Displays all the entries in a journal
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }
    private List<string> ParseCsv(string csv)
    {
        //Parses through the CSV file to properly format quotation marks and commas.
        //Returns the proper format in a list of strings so that it can then be separated into their proper Entry Attributes later.
        var _fields = new List<string>();
        bool _insideQuotes = false;
        var _field = new System.Text.StringBuilder();

        for (int i = 0; i < csv.Length; i++)
        {
            char _parse = csv[i];

            if (_parse == '"')
            {
                if (_insideQuotes && (i + 1 < csv.Length) && csv[i + 1] == '"')
                {
                    _field.Append('"');
                    i++;
                }
                else
                {
                    _insideQuotes = !_insideQuotes;
                }
            }
            else if (_parse == ',' && !_insideQuotes)
            {
                _fields.Add(_field.ToString());
                _field.Clear();
            }
            else
            {
                _field.Append(_parse);
            }
        }
        _fields.Add(_field.ToString());
        return _fields;
    }
    public void AddEntry()
    {
        //Adds a new entry into the _entries list in the Journal Class
        Entry entry = new Entry();
        DateTime _theCurrentTime = DateTime.Now;
        entry._date = _theCurrentTime.ToShortDateString();
        entry._prompt = entry.RandomPrompt();
        Console.WriteLine($"{entry._date}:");
        Console.WriteLine($"{entry._prompt}");
        Console.Write($"");
        entry._response = Console.ReadLine();
        _entries.Add(entry);
    }
    public int GetChoice()
    {
        //Displays the options that the user can pick and returns the number they input.
        Console.WriteLine("1: Write");
        Console.WriteLine("2: Display");
        Console.WriteLine("3: Load");
        Console.WriteLine("4: Save");
        Console.WriteLine("5: Quit");
        Console.Write("What would you like to do? ");
        int i = int.Parse(Console.ReadLine());
        return i;
    }
    public void SaveJournal()
    {
        //Saves the currently saved Journal object into a csv file.
        Console.Write("What would you like to name the journal? ");
        _name = Console.ReadLine();
        Console.WriteLine("The file will be saved under this name as a .csv");
        string _fileName = $"{_name}.csv";
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            outputFile.WriteLine("Date,Prompt,Response");
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry.WriteDisplay());
            }
            Console.WriteLine("File successfuly saved");
            Console.WriteLine();
        }
    }
    public void LoadJournal()
    {
        //Loads a csv formatted file to be saved into the _entries list of Entries
        Console.Write("Which journal would you like to load (don't add .csv)? ");
        _name = Console.ReadLine();
        string _fileName = $"{_name}.csv";
        string[] _lines = System.IO.File.ReadAllLines(_fileName);
        bool _firstLine = true;
        foreach (string line in _lines)
        {
            if (_firstLine)
            {
                _firstLine = !_firstLine;
                continue;
            }
            Entry entry = new();
            var _fields = ParseCsv(line);
            entry._date = _fields[0];
            entry._prompt = _fields[1];
            entry._response = _fields[2];
            _entries.Add(entry);
            }
    }
}