using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int numCheck = 1;
        double sum = 0;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (numCheck != 0)
        {
            Console.Write("Enter number: ");
            numCheck = int.Parse(Console.ReadLine());
            if (numCheck != 0)
            {
                numbers.Add(numCheck);
            }
        }
        numbers.Sort();
        int largestNum = numbers[0];
        int smallestNum = numbers[0];
        for (int i = 0; smallestNum <= 0; i++)
        {
            smallestNum = numbers[i];
        }
        foreach (int num in numbers)
        {
            sum += num;
        }
        for (int i = 1; i < numbers.Count; i++)
        {
            if (numbers[i] > largestNum)
            {
                largestNum = numbers[i];
            }
        }
        for (int i = 1; i < numbers.Count; i++)
        {
            if (numbers[i] < smallestNum && numbers[i] > 0)
            {
                smallestNum = numbers[i];
            }
        }
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {sum / numbers.Count}");
        Console.WriteLine($"The largest number is: {largestNum}");
        Console.WriteLine($"The smallest positive number is: {smallestNum}");
        Console.WriteLine("The sorted list is: ");
        foreach (int sort in numbers)
        {
            Console.WriteLine(sort);
        }
    }
}