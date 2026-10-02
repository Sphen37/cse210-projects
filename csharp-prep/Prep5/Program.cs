using System;
using System.Configuration.Assemblies;
using System.Diagnostics;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        int birthYear;
        DisplayWelcome();

        string name = PromptUserName();
        int favNum = PromptUserNumber();

        PromptUserBirthYear(out birthYear);

        int squaredNum = SquareNumber(favNum);
        
        DisplayResult(name, squaredNum, birthYear);

    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int num = int.Parse(Console.ReadLine());
        return num;
    }
    static void PromptUserBirthYear(out int birthYear)
    {
        Console.Write("Please enter the year you were born: ");
        birthYear = int.Parse(Console.ReadLine());
    }
    static int SquareNumber(int num)
    {
        num = num*num;
        return num;
    }
    static void DisplayResult(string name, int num, int year)
    {
        int age = 2026 - year;
        Console.WriteLine($"{name}, the square of your number is {num}");
        Console.WriteLine($"{name}, you will turn {age} this year.");
    }
}