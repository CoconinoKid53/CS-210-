class Journal {
    public List<Entry> _entries= new List<Entry>() ;
    Prompt _prompt = new Prompt();
    public void createJorunalEntry(){
        // Create a new entry object
        Entry entry = new Entry ();
        // Get the current time
        DateTime theCurrentTime = DateTime.Now;
        entry._date = theCurrentTime.ToShortDateString();
        // Get a random prompt
        string prompt = _prompt.randomReturnPrompt(); // Grab the prompt
        entry._prompt = prompt; // Store the prompt

        // Display the prompt to the user
        Console.WriteLine($"{entry._prompt}");
        Console.Write("--> ");
        // Collect user input
        entry._text = Console.ReadLine();

        // Record the entry
        _entries.Add(entry);
    }

    public void displayAllEntries () {
        // Display all the entries in the journal.
        int counter = 1;
        foreach (Entry entry in _entries) {
            Console.WriteLine($"Entry #{counter}");
            entry.Display();
            Console.WriteLine();
            counter ++;
        }
    }

    // Save journal to a (new function)
    public void saveallentries() {
        string fileName = "myFile.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            // You can add text to the file with the WriteLine method
            foreach (Entry journalEntries in _entries){
                outputFile.WriteLine($"{journalEntries._date}${journalEntries._prompt}${journalEntries._text}");

            }
        }
    }

    public void loadallentries() {
        string filename = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("$");

            string Date = parts[0];
            string prompt = parts[1];
            string entry = parts[2];

            Entry entry1 = new Entry();
            entry1._date = Date;
            entry1._prompt = prompt;
            entry1._text = entry;
            _entries.Add(entry1);

        }
    }   // Load journal from a file (new function)

}