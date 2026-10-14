class Journal
{
    public List<Entry> _entries = [];
    public string _name = "";
    public string _text = "";
    public void DisplayEntry()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }
    private List<string> ParseCsv(string csv)
    {
        var fields = new List<string>();
        bool insideQuotes = false;
        var field = new System.Text.StringBuilder();

        for (int i = 0; i < csv.Length; i++)
        {
            char parse = csv[i];

            if (parse == '"')
            {
                if (insideQuotes && (i + 1 < csv.Length) && csv[i + 1] == '"')
                {
                    field.Append('"');
                    i++;
                }
                else
                {
                    insideQuotes = !insideQuotes;
                }
            }
            else if (parse == ',' && !insideQuotes)
            {
                fields.Add(field.ToString());
                field.Clear();
            }
            else
            {
                field.Append(parse);
            }
        }
        fields.Add(field.ToString());
        return fields;
    }
    public void AddEntry()
    {
        Entry entry = new Entry();
        DateTime theCurrentTime = DateTime.Now;
        entry._date = theCurrentTime.ToShortDateString();
        entry._prompt = entry.RandomPrompt();
        Console.WriteLine($"{entry._date}:");
        Console.WriteLine($"{entry._prompt}");
        Console.Write($"");
        entry._response = Console.ReadLine();
        _entries.Add(entry);
    }
    public int GetChoice()
    {
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
        //https://byui-cse.github.io/cse210-course-2023/unit02/develop.html
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

        Console.Write("Which journal would you like to load (don't add .csv)? ");
        _name = Console.ReadLine();
        string _fileName = $"{_name}.csv";
        string[] _lines = System.IO.File.ReadAllLines(_fileName);
        bool firstLine = true;
        foreach (string line in _lines)
        {
            if (firstLine)
            {
                firstLine = !firstLine;
                continue;
            }
            Entry entry = new();
            var fields = ParseCsv(line);
            entry._date = fields[0];
            entry._prompt = fields[1];
            entry._response = fields[2];
            _entries.Add(entry);
            }
    }
}