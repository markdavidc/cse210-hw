class Scripture
{
    private Verse _verse;
    private List<Word> _words;

    public Scripture(Verse verse, string text)
    {
        _verse = verse;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void DisplayScripture()
    {
        Console.Clear();
        Console.WriteLine(_verse);
        foreach (var word in _words)
        {
            Console.Write(word.GetDisplayText() + " ");
        }
        Console.WriteLine();
    }

    public bool HideRandomWords(int count)
    {
        var visibleWords = _words.Where(word => !word.IsHidden()).ToList();

        if (visibleWords.Count == 0)
            return false;

        var random = new Random();
        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }

        return true;
    }

    public bool AreAllWordsHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}
