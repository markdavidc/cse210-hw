class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = InitializeScripture(); 
        scripture.DisplayScripture();
        
        bool quit = false;

        while (!quit)
        {
            Console.WriteLine("Press Enter to hide words, or type 'quit' to exit.");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                quit = true;
                break;
            }

            if (scripture.HideRandomWords(3))
            {
                scripture.DisplayScripture();

                if (scripture.AreAllWordsHidden())
                {
                    Console.WriteLine("All words are hidden. The program will now end.");
                    break;
                }
            }
            else
            {
                Console.WriteLine("All words are already hidden.");
                break;
            }
        }

        Console.WriteLine("Thanks for practicing! Goodbye.");
    }

 static Scripture InitializeScripture()
    {
        var scriptures = new List<Scripture>
        {
            new Scripture(new Verse("John", 3, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
            new Scripture(new Verse("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."),
            new Scripture(new Verse("Philippians", 4, 13), "I can do all things through Christ which strengtheneth me."),
            new Scripture(new Verse("Psalm", 23, 1, 2), "The Lord is my shepherd; I shall not want. He maketh me to lie down in green pastures: he leadeth me beside the still waters.")
        };
        var random = new Random();
        return scriptures[random.Next(scriptures.Count)]; 
    }
}