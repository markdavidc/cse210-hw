using System;


public class EternalGoal : Goal
{
    private string _goalType = "Eternal";
    private int _goalPoints;
    private int _timesCompleted = 0;
    private bool _goalComplete = false;

    public EternalGoal()
    {
    }
    public EternalGoal(string goalName, string goalDescription, int goalPoints, int timesCompleted, bool goalComplete) : base (goalName, goalDescription)
    {
        _goalPoints = goalPoints;
        _timesCompleted = timesCompleted;
        _goalComplete = goalComplete;
    }
        public int GetRunningTotal()
    {
        return _timesCompleted;
    }

    public override void DisplayGoalPoints()
    {
        Console.Write("How many points is this goal worth each time you complete it? ");
        _goalPoints = int.Parse(Console.ReadLine());
        return;
    }
    public override int GetGoalPoints()
    {
        return _goalPoints;
    }
    
    public override bool GetGoalStatus()
    {
        return _goalComplete;
    }

    public override string ToCSVRecord()
    {
        return $"{_goalType}|{GetGoalName()}|{GetGoalDescription()}|{GetGoalPoints()}|{GetRunningTotal()}|{_goalComplete}";
    }

    public override string ToString()
    {
        return $"[ ] {GetGoalName()} ({GetGoalDescription()}) - Completed {GetRunningTotal()} times";
    }

    public override void RecordEvent()
    {
        _timesCompleted += 1;
        Console.WriteLine($"Congratulations! You have earned {GetGoalPoints()} points!");
    }
}