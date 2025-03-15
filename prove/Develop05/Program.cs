using System;
class Program
{
    static void Main(string[] args)
    {
        AllGoals allGoals = new AllGoals();
        int userMainMenuSelection = 0;

        Console.Clear();
        Console.WriteLine("Welcome to the Goal Tracking App!");
        Console.WriteLine();

        while (userMainMenuSelection != 6)
        {
            Menu menu = new Menu();
            allGoals.DisplayPoints(allGoals.getTotalPoints());
            Console.WriteLine();
            menu.DisplayMainMenu();
            userMainMenuSelection = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (userMainMenuSelection)
            {
                case 1:
                    menu.DisplayNewGoalMenu();
                    int userNewGoalSelection = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Goal goal = null;
                    if (userNewGoalSelection == 1)
                    {
                        goal = new SimpleGoal();
                        goal.DisplayGoalName();
                        goal.DisplayGoalDescription();
                        goal.DisplayGoalPoints();
                    }
                    else if (userNewGoalSelection == 2)
                    {
                        goal = new EternalGoal();
                        goal.DisplayGoalName();
                        goal.DisplayGoalDescription();
                        goal.DisplayGoalPoints();
                    }
                    else
                    {
                        goal = new CheckListGoal();
                        goal.DisplayGoalName();
                        goal.DisplayGoalDescription();
                        goal.DisplayGoalPoints();
                    }

                    if (goal != null)
                    {
                        allGoals.addGoal(goal);
                    }
                    break;

                case 2:
                    allGoals.DisplayGoals();
                    break;

                case 3:
                    allGoals.SaveGoals();
                    break;

                case 4:
                    allGoals.LoadGoals();
                    break;

                case 5:
                    allGoals.DisplayGoalRecordEvent();
                    break;

                case 6:
                    Console.Write("Do you want to save before you quit (y/n)? ");
                    string userInput = Console.ReadLine();
                    if (userInput == "y")
                    {
                        allGoals.SaveGoals();
                    }

                    Console.WriteLine();
                    Console.WriteLine("Thank you! Goodbye. ");
                    break;

                default:
                    Console.WriteLine("Please select a valid option.");
                    break;

            }
        }
    }
}