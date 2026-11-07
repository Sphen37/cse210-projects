using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        //Initializes new instances of all the child classes. 
        Breathing breathing = new();
        Listing listing = new();
        Reflection reflection = new();
        //Sets choice to 0 so the menu can run infinitely until the user chooses 5
        int choice = 0;
        while (choice != 5)
        {    
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. List time stats for all activities");
            Console.WriteLine("  5. Quit");
            Console.Write("Select a choice from the menu: ");
            //Makes sure the user inputs an int and makes sure it doesn't break if they don't
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                if (choice == 1)
                {
                    //Runs the Breathing activity if the user chooses 1
                    breathing.Breath();
                }
                else if (choice == 2)
                {
                    //Runs the Reflection activity if the user chooses 2
                    reflection.Reflect();
                }
                else if (choice == 3)
                {
                    //Runs the Listing activity if the user chooses 3
                    listing.List();
                }
                else if (choice == 4)
                {
                    //Displays the time stats for each activity until the user presses enter
                    Console.Clear();
                    breathing.TimeStats();
                    reflection.TimeStats();
                    listing.TimeStats();
                    Console.WriteLine("Press enter to go back to the menu");
                    Console.ReadLine();
                }
            }
        }
    }
}