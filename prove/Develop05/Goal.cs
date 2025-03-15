using System;
public class Goal
{
    private string _goalName;
    private string _goalDescription;

    public Goal()
    {}
    public Goal(string goalName, string goalDescription)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
    }

    public string GetGoalName()
    {
        return _goalName;
    }
    public void SetGoalName(string goalName)
    {
        _goalName = goalName;
    }
    public string GetGoalDescription()
    {
        return _goalDescription;
    }
    public void SetGoalDescription(string goalDescription)
    {
        _goalDescription = goalDescription;
    }

       public virtual void DisplayGoalPoints()
    {
        return;
    }
    public virtual int GetGoalPoints()
    {
        return 0;
    }

    public virtual bool GetGoalStatus()
    {
        return false;
    }

    public virtual string ToCSVRecord()
    {
        return "";
    }
    public virtual void RecordEvent()
    {
    }

    public string DisplayGoalName()
    {
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();
        return _goalName;
    }

    public string DisplayGoalDescription()
    {
        Console.Write("What is the description of your goal? ");
        _goalDescription = Console.ReadLine();
        return _goalDescription;
    }

 
}