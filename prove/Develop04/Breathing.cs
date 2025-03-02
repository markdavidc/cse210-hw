using System;

public class BreathingActivity : Activity
{


    public BreathingActivity() : base()
    {
        SetActivityName("Breathing Activity");

        SetActivityDescription("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
    }

    public void RunBreathingActivity()
    {
        RunActivityParentStart();
        DisplayInOut();
        RunActivityParentEnd();
    }

    public void DisplayInOut()
    {
        int time = GetUserSessionLengthInput() * 1000;
        int intervalTime = 10000;
        int intervals = time / intervalTime;

        for(int i = 0; i < intervals; i++)
        {
            Console.Write("Breathe in... ");
            CountUp();
            Console.WriteLine();
            
            Console.Write("Breathe out... "); 
            Countdown();
            Console.WriteLine();
        }
    }

    private void Countdown()
    {
        for (int i = 4; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    private void CountUp()
    {
        for (int i = 1; i <= 4; i++)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

}