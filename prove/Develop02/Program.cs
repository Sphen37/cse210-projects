using System;
using System.IO;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Journal _newJournal = new();
        int loop = 0;
        do
        {
        loop = _newJournal.GetChoice();
        if (loop == 1)
            {
                _newJournal.AddEntry();  
            }
        else if (loop == 2)
            {
                _newJournal.DisplayEntry();
            }
        else if (loop == 3)
            {
                _newJournal.LoadJournal();
            }
        else if (loop == 4)
            {
                _newJournal.SaveJournal();
            }
        else if (loop == 5)
            {
                loop = 0;
            }
        } while(loop != 0);
    }
}