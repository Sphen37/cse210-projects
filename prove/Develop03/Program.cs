using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        //Runs the program and starts by clearing the console displaying a starting message
        Console.Clear();
        Console.WriteLine("===Memorize Scripture===");
        Thread.Sleep(2500);
        Scripture scripture = new();
        int choice = 0; 
        choice = scripture.GetChoice();
        if  (choice == 1)
        {
            //If the user chooses this option it will bring up pre-built scripture for the user to memorize
            scripture.Hide();
        }
        else if (choice == 2)
        {
            //If the user chooses this option it will prompt them to input their own scripture that they want to memorize.
            //This is part of my exceeding requirements goal.
            //I wanted to be able to add my own scriptures without having to manipulate the code, so I added the ability to set one.
            scripture.SetScripture();
            scripture.Hide();
        }
    }
}