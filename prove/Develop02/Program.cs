using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal(); // Create a new journal instance

        string[] prompts = { // List of prompts for journal entries
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "Did I pray for the Holy Spirit Guidance?",
            "What a lesson I learned today?",
            "Did I follow my pace guide today?"
        };

        Random rand = new Random(); // Random object for selecting prompts entries

        while (true) // Start Main menu loop
        {
            // Display menu options
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine(); // Read user's choice

            switch (choice)
            {
                case "1":
                    string prompt = prompts[rand.Next(prompts.Length)]; // Select a random prompt
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine(); // Read user's response
                    journal.AddEntry(new Entry(prompt, response)); // Add a new entry to the journal
                    break;
                case "2":
                    journal.DisplayEntries(); // Display all entries in the journal
                    break;
                case "3":
                    Console.Write("Enter filename to save: ");
                    string saveFilename = Console.ReadLine(); // Read filename from user
                    journal.SaveToFile(saveFilename); // Save journal to a file
                    break;
                case "4":
                    Console.Write("Enter filename to load: ");
                    string loadFilename = Console.ReadLine(); // Read filename from user
                    journal.LoadFromFile(loadFilename); // Load journal from a file
                    break;
                case "5":
                    Console.WriteLine("Exiting...");
                    return; // Exit the program
                default:
                    Console.WriteLine("Invalid option. Please try again."); // Display error message for invalid input
                    break;
            }
        }
    }
}