using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address ("2748 Oakridge Drive", "Springfild", "MO", "65804", "USA");
        string lectureAddress = address1.GetAddress();
        Lectures lecture = new Lectures("Climate Change", "A deep dive into how shifting climate patterns are impacting agriculture worldwide", "June 12, 2025", "10:30 am - 12:30 pm", $"{lectureAddress}", "Lecture", "Olivia Bennett", 500);

        //display lecture event details
        Console.WriteLine("---------------------------------------------------------------------------");
        lecture.DisplayShortDescription();
        Console.WriteLine();
        lecture.DisplayStandardDetails();
        Console.WriteLine();
        lecture.DisplayLectureFullDetails();


        Address address2 = new Address ("983 Willow Creek Lane", "Boulder", "CO", "80302", "USA");
        string receptionAddress = address2.GetAddress();
        Receptions reception = new Receptions("Spring Research Showcase", "Join faculty, students, and guests in celebrating the innovative research projects completed this semester.", "September 22, 2025", "5:00 pm - 9:00pm", $"{receptionAddress}", "Reception", "Spring123@gmail.com");
        //display reception event details
        Console.WriteLine("---------------------------------------------------------------------------");
        reception.DisplayShortDescription();
        Console.WriteLine();
        reception.DisplayStandardDetails();
        Console.WriteLine();
        reception.DisplayReceptionsFullDetails();


        Address address3 = new Address ("1423 Maple Hollow Drive", "Raleigh", "NC", "27609", "USA");
        string outdoorAddress = address3.GetAddress();
        Outdoor outdoor = new Outdoor("Sunset Yoga in the Park", "Unwind with a guided yoga session under the setting sun. P.S. Please bring your own mat and water bottle ", "July 26, 2025", "7:00 pm - 8:15pm", $"{outdoorAddress}", "Outdoor", "Sunny");
        //display outdoor event details
        Console.WriteLine("---------------------------------------------------------------------------");
        
        outdoor.DisplayShortDescription();
        Console.WriteLine();
        outdoor.DisplayStandardDetails();
        Console.WriteLine();
        outdoor.DisplayOutdoorFullDetails();
        Console.WriteLine("---------------------------------------------------------------------------");
        
    }
}
