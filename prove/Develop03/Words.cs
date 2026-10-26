using System.ComponentModel;
using System.Net;

class Words
{
    private bool _isHidden;
    private List<string> _words;
    private List<string> _finalWords;

    public Words()
    {
        //Initializes an empty Words class object.
        _isHidden = false;
        _words = [];
        _finalWords = [];
    }
    public Words(string words)
    {
        //Initializes and parses the string inputted by the user to be inputted into a list of strings so that it can be manipulated.
        _isHidden = false;
        _words = [];
        _finalWords = [];
        var wordBuilder = new System.Text.StringBuilder();
        for (int i = 0; i < words.Length; i++)
        {
            char parse = words[i];
            if (parse == ' ')
            {
                _words.Add(wordBuilder.ToString());
                _finalWords.Add(wordBuilder.ToString());
                wordBuilder.Clear();
            }
            else
            {
                wordBuilder.Append(parse);
            }
        }
        _words.Add(wordBuilder.ToString()); 
        _finalWords.Add(wordBuilder.ToString());
    }
    public void HideWords()
    {
        //Hides the words randomly and then separates them into two lists.
        //_finalList stores the manipulated list with the new blanked out words
        //_words has the chosen hidden word removed so that it can't be chosen again.
        if (!_isHidden)
        {
            Random randomHide = new();
            var hideBuilder = new System.Text.StringBuilder();
            for (int i = 0; i < 3; i++)
            {
                if (_words.Count == 0)
                {
                    //If the word count is zero it will just skip trying to run the rest of the code here.
                    continue;
                }
                int random = randomHide.Next(0,_words.Count);
                string removedWord  = _words[random];
                for (int j = 0; j < removedWord.Length; j++)
                {
                    //Parses the chosen hidden word and replaces each character inside of it with an _
                    hideBuilder.Append('_');
                }
                _words.Remove(removedWord); 
                _finalWords[_finalWords.IndexOf(removedWord)] = hideBuilder.ToString();
                hideBuilder.Clear();
            }
            if (_words.Count == 0)
            {
                //sets _isHidden to true so that it will stop the program.
                _isHidden = !_isHidden;
            }
        }
    }
    public string GetWords()
    {
        //Combines the list of strings back into a single for easy reading.
        string sentence = "";
        foreach (string word in _finalWords)
        {
            sentence = sentence + word + " ";
        }
        return sentence;     
    }
    public bool GetIsHidden()
    {
        //Returns the value of _isHidden
        return _isHidden;
    }
    public void SetWords()
    {
        //Allows the user to set the words of the scripture after the class has been initialized.
        //All of htis is part of my exceeding requirements goal.
        _words = [];
        _finalWords = [];
        Console.WriteLine("What are the words to your scripture (ignore the verse numbers)?");
        string words = Console.ReadLine();
        var wordBuilder = new System.Text.StringBuilder();
        for (int i = 0; i < words.Length; i++)
        {
            char parse = words[i];
            if (parse == ' ')
            {
                _words.Add(wordBuilder.ToString());
                _finalWords.Add(wordBuilder.ToString());
                wordBuilder.Clear();
            }
            else
            {
                wordBuilder.Append(parse);
            }
        }
        _words.Add(wordBuilder.ToString()); 
        _finalWords.Add(wordBuilder.ToString());
    }

}