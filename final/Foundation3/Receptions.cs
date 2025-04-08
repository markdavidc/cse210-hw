using System; 

public class Receptions : Event
{   
    private string _email {get; set;}   

    public Receptions(string title, string description, string date, string time, string address, string type, string email) : base (title, description, date, time, address, type)
    {
        _email = email;
    }

    public void DisplayReceptionsFullDetails()
    {   
        
        DisplayFullDetails();
        Console.WriteLine($"RSVP E-mail: {_email}");
    }
}