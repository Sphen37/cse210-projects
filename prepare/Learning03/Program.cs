using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction _fraction = new();
        Random _randomNum = new();
        for (int i = 1; i < 25; i++)
        {
            _fraction.SetTop(_randomNum.Next(1,25));
            _fraction.SetBottom(_randomNum.Next(1,25));
            string str = _fraction.GetFractionString();
            double num = _fraction.GetDecimalValue();
            Console.WriteLine($"Fraction {i}: string: {str} Number: {num}");
        }
    }
}