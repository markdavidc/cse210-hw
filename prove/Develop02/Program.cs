using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();
        int choice = -1;
        Journal journal = new Journal();
        do
        {   
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do ? ");
            choice = int.Parse(Console.ReadLine());

            switch(choice) 
            {
                case 1:
                    journal.AddEntry();
                    break;
                case 2:
                    journal.Display();
                    break;
                case 3:
                    journal.LoadFromCSV();
                    break;
                case 4:
                    journal.SaveToCSV();
                    break;
                case 5:
                    Console.WriteLine("Good Bye");
                    break;
                default:
                    Console.WriteLine("Please Select a correct value");
                    break;
            }
        }while (choice != 5);
    }
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Journal program!");
    }
} 