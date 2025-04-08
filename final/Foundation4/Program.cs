using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activityList = new List<Activity>();
        
        Running running = new Running("April 7, 2025", 45, 6.2);
        activityList.Add(running);

        Cycling cycling = new Cycling("March 17, 2025", 50, 12);
        activityList.Add(cycling);

        Swimming swimming = new Swimming("January 24, 2025", 10, 10);
        activityList.Add(swimming);

        Console.WriteLine("Exercises:");
        Console.WriteLine();

        foreach (Activity activity in activityList) 
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
