class Journal
{
    private List<Entry> entries = new List<Entry>();

    public void AddEntry()
    {
        Prompt promptGenerator = new Prompt();
        string prompt = promptGenerator.GetRandomPrompt();
        
        Console.WriteLine("Prompt: " + prompt);
        Console.Write("Write your journal entry: ");
        string text = Console.ReadLine();
        
        Entry entry = new Entry(DateTime.Now, prompt, text);
        entries.Add(entry);
        Console.WriteLine("Entry added successfully!");
    }

    public void Display()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No entries to display.");
            return;
        }

        foreach (Entry entry in entries)
        {
            entry.Display();
            Console.WriteLine(); 
        }
    }

    public void SaveToCSV()
    {
        Console.Write("Enter filename to save to (Journal.csv): ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine("Date,Prompt,Text");

            foreach (Entry entry in entries)
            {
                string sanitizedPrompt = entry.Prompt.Replace(",", ";");
                string sanitizedText = entry.Text.Replace(",", ";");

                writer.WriteLine($"{entry.Date},{sanitizedPrompt},{sanitizedText}");
            }
        }

        Console.WriteLine("Journal saved to " + filename);
    }

    public void LoadFromCSV()
    {
        Console.Write("Enter filename to load from (Journal.csv): ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        entries.Clear();
        using (StreamReader reader = new StreamReader(filename))
        {
            reader.ReadLine();

            while (!reader.EndOfStream)
            {
                string[] values = reader.ReadLine().Split(',');

                DateTime date = DateTime.Parse(values[0]);
                string prompt = values[1].Replace(";", ","); 
                string text = values[2].Replace(";", ",");

                Entry entry = new Entry(date, prompt, text);
                entries.Add(entry);
            }
        }

        Console.WriteLine("Journal loaded from " + filename);
    }
}