class Entry
{
    public DateTime Date { get; }
    public string Prompt { get; }
    public string Text { get; }

    public Entry(DateTime date, string prompt, string text)
    {
        Date = date;
        Prompt = prompt;
        Text = text;
    }

    public void Display()
    {
        Console.WriteLine("Date: " + Date);
        Console.WriteLine("Prompt: " + Prompt);
        Console.WriteLine("Entry: " + Text);
    }
}