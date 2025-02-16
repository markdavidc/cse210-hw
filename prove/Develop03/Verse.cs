class Verse
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    public Verse(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = verse;
    }

    public Verse(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public override string ToString()
    {
        return _endVerse == _startVerse ? $"{_book} {_chapter}:{_startVerse}" : $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
    }
}