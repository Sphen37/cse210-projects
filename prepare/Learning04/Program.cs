using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment _assignment = new("Samuel Bennett", "Multiplication");
        Console.WriteLine(_assignment.GetSummary());
        MathAssignment _mathAssignment = new("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(_mathAssignment.GetSummary());
        Console.WriteLine(_mathAssignment.GetHomeworkList());
        WritingAssignment _writingAssignment = new("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(_writingAssignment.GetSummary());
        Console.WriteLine(_writingAssignment.GetWritingInformation());
    }
}