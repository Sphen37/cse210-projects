using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your first name? ");
        string firstName = Console.ReadLine();
        firstName = firstName.Trim();
        Console.WriteLine("What is your last name? ");
        string lastName = Console.ReadLine();
        lastName = lastName.Trim();
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}