using System;


public class Menu
{
    private List<string> _mainMenu;
    private List<string> _createGoalMenu;

    public Menu()
    {
        _mainMenu = new List<string>
        {
            "Menu Options:",
            "  1. Create New Goal",
            "  2. List Goals",
            "  3. Save Goals",
            "  4. Load Goals",
            "  5. Record Event",
            "  6. Quit"
        };

        _createGoalMenu = new List<string>
        {
            "The types of Goals are:",
            "  1. Simple Goal",
            "  2. Eternal Goal",
            "  3. CheckList Goal"
        };
    }

    public void DisplayMainMenu()
    {
        foreach (string menuItem in _mainMenu)
        {
            Console.WriteLine(menuItem);
        }

        Console.Write("Select a choice: ");
       
    }

    public void DisplayNewGoalMenu()
    {
        foreach (string menuItem in _createGoalMenu)
        {
            Console.WriteLine(menuItem);
        }
        Console.Write("Select a choice from the menu: ");
    }

}