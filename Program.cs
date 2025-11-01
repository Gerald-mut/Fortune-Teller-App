using System;
using System.Collections.Generic;

class Program
{
    
        

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome, mortal. I peer into your future... but only between coffee breaks.");
        Console.WriteLine("What is your name mortal?");
        string name = Console.ReadLine();
        Console.WriteLine($"Hello {name}, I will now tell you your fortune.....");

        System.Threading.Thread.Sleep(1000);
        List<string> fortunes = new List<string>()
        {
            "A beautiful stranger will bring you coffee tomorrow.",
            "Your code will compile on the first try next week.",
            "You will find that missing semicolon very soon.",
            "A mysterious bug in your code will suddenly fix itself.",
            "Your next project will be completed ahead of schedule.",
            "You will become fluent in a new programming language.",
            "A rubber duck will solve your biggest problem."
        };

        Random random = new Random();

        int index = random.Next(fortunes.Count);
        Console.WriteLine("\n🔮 Your fortune is:");
        Console.WriteLine(fortunes[index]);

            // Add closing message
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}