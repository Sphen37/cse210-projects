using System;

class Program
{
    static void Main(string[] args)
    {
        // Creates variables for each string that is changed by the if-statements.
        string letter;
        string preposition;
        string sign;
        // This is where the user inputs their letter percentage.
        Console.WriteLine("What's your letter percentage? ");
        float letterPercent = float.Parse(Console.ReadLine());
        // This if statement determines what letter is assigned to each grade
        if (letterPercent >= 90)
        {
            letter = "A";
        }
        else if (letterPercent < 90 && letterPercent >= 80)
        {
            letter = "B";
        }
        else if (letterPercent < 80 && letterPercent >= 70)
        {
            letter = "C";
        }
        else if (letterPercent < 70 && letterPercent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        // This determines whether they are above a certain percentage in each letter bracket
        if (letterPercent % 10 >= 7 || (letterPercent >= 50 && letterPercent < 60) || letterPercent >= 100)
        {
            sign = "+";
        }
        else if (letterPercent % 10 < 3 || letterPercent < 40)
        {
            sign = "-";
        }
        else if (letterPercent >= 40 && letterPercent < 50)
        {
            sign = "";
        }
        else
        {
            sign = "";
        }
        // This helps the final message be more grammatically correct
        if (letter == "A" || letter == "F")
        {
            preposition = "an";
        }
        else
        {
            preposition = "a";
        }
        // This prints what their exact grade letter is
        Console.WriteLine($"You finished with {preposition} {letter}{sign}.");
        // This determines if they passed the class or not
        if (letter == "A" || letter == "B" || letter == "C")
        {
            Console.WriteLine("Congratulations you passed the class!!!");
        }
        else
        {
            Console.WriteLine("You'll get 'em next time bud.");
        }
    }
}