class Journal
{
    private List<Entry> _entries = new List<Entry>();

    // Add an Entry method to add a new entry to the journal
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    // DisplayEntries method to display all entries in the journal
    public void DisplayEntries()
    {
        foreach (var entry in _entries)
        {
            Console.WriteLine(entry);
        }
    }

    // SaveToFile method to save the journal to a external file
    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                // Each entry is saved as a line in the file with date, prompt, and response separated by ';'
                writer.WriteLine($"{entry._date};{entry._prompt};{entry._response}");
            }
        }
    }

    // LoadFromFile method to load entries from a file into the journal
    public void LoadFromFile(string filename)
    {
        _entries.Clear(); // Clear existing entries before loading from file
        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(';');
                if (parts.Length == 3)
                {
                    // Parse date from string and create a new entry
                    DateTime date;
                    if (DateTime.TryParse(parts[0], out date))
                    {
                        _entries.Add(new Entry(parts[1], parts[2]) { Date = date });
                    }
                }
            }
        }
    }
}