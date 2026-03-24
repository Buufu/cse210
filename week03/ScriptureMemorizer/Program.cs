// EXCEEDING REQUIREMENTS:
// This program was enhanced to only hide words that are not already hidden.
// This improves the memorization experience by ensuring new words are hidden
// each time instead of randomly selecting already hidden words.
using System;

class Program
{
    static void Main(string[] args)
 {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference,
            "Trust in the Lord with all thine heart and lean not unto thine own understanding");

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(3);
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nProgram ended.");
    }
}