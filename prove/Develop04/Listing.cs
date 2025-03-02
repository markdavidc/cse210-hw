using System;

public class ListingActivity : Activity
{
    private string _randomPrompt { get; set; }
    private List<string> _prompts;

    public ListingActivity() : base()
    {
        SetActivityName("Listing Activity");
        SetActivityDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        _prompts = new List<string>
        {
            "--- Who are people that you appreciate? ---",
            "--- What are personal strengths of yours? ---",
            "--- Who are people that you have helped this week? ---",
            "--- When have you felt the Holy Ghost this month? ---",
            "--- Who are some of your personal heroes? ---"
        };
    }


    public void RunListingActivity()
    {
        RunActivityParentStart();
        DisplayPrompt();
        ListingCounter();
        RunActivityParentEnd();
    }
    private void DisplayPrompt()
    {
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();
        int randomIndex = new Random().Next(0, _prompts.Count());
        Console.WriteLine(_prompts[randomIndex]);
        Console.WriteLine();
    }

    private void ListingCounter()
    {
         DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetUserSessionLengthInput());
        DateTime currentTime = DateTime.Now;
        int count = 0;
        while (currentTime < futureTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            count += 1;
            currentTime = DateTime.Now;
        }
        Console.WriteLine();
        Console.WriteLine($"You listed {count} items.");
        DisplaySpinner(5);
    }
}