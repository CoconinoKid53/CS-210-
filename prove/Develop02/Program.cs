using System; 
// Don't forget to put this at the top, so C# knows where to find the StreamWriter class
using System.IO; 


class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        // Collect user input as long as they want to run the program
        Console.WriteLine("Welcome to the Journal Program.");
        string userInput = "";
        while (userInput != "Q") {
            Console.WriteLine("Please select from the following options:");
            Console.WriteLine("* [W]rite a new entry");
            Console.WriteLine("* [D]isplay the journal");
            Console.WriteLine("* [S]ave the journal to a file");
            Console.WriteLine("* [L]oad the journal from a file");
            Console.WriteLine("* [Q]uit");
            Console.Write("--> ");

            // Collect user input
            userInput = Console.ReadLine().ToUpper();

            // Handle the user input
            switch (userInput) {
                case "W":
                    // Prompt the user for their journal entry
                    // Save the journal entry to the journal
                    journal.createJorunalEntry();
                    break;
                case "D":
                    // Call a function which displays all of the journal entries
                    journal.displayAllEntries();
                    break;
                case "S":
                    // Call a function to save the journal to a file
                    journal.saveallentries();
                    break;
                case "L":
                    // Prompt the user for a filename, then call a function to
                    // load the info
                    journal.loadallentries();
                    break;
                case "Q":
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Not valid input");
                    break;
            }
        }
    }
} 


