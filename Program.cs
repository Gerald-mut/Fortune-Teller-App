// 'using System;' imports the core .NET library, giving us access to
// tools like 'Console' and 'Random'.
using System;
using System.Collections.Generic;

class Program
{
    // The Main method is the entry point. Our app starts running here.
    static void Main(string[] args)
    {
        // Greet the user and get their name
        Console.WriteLine("Welcome, mortal. I peer into your future... but only between coffee breaks.");
        Console.WriteLine("What is your name mortal?");

        // Console.ReadLine() waits for the user to type and press Enter.
        // We store their input in a 'string' variable called 'name'.
        string name = Console.ReadLine();

        // Greet the user by name.
        // The '$' sign creates an "interpolated string",
        // allowing us to put variables directly inside {}.
        Console.WriteLine($"Hello {name}, I will now tell you your fortune.....");

        System.Threading.Thread.Sleep(1000);
        List<string> fortunes = new List<string>()
        {
            "You will find a great new opportunity this week.",
            "A surprise visit will bring you joy.",
            "Trust your intuition; it is leading you correctly.",
            "Patience will be rewarded in an unexpected way.",
            "A challenging project will soon be completed successfully."
        };


        // Get a random fortune
        // Create an instance of the Random class.
        Random random = new Random();

        // fortunes.COunt gets the number of elements in the list
        int index = random.Next(fortunes.Count);
        Console.WriteLine("\n🔮 Your fortune is:");
        Console.WriteLine(fortunes[index]);

        // Add closing message
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}