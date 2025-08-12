using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Movie Ticketing System ===\n");
        
        Console.WriteLine("Problem 1: Age-Based Pricing");
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());
        
        Console.Write("Time of day (AM/PM): ");
        string timeOfDay = Console.ReadLine().ToUpper();
        
        Console.Write("Day of week: ");
        string dayOfWeek = Console.ReadLine().ToLower();
        
        int ticketPrice;
        if (age < 13)
        {
            ticketPrice = 150;
        }
        else if (age >= 60)
        {
            ticketPrice = 120;
        }
        else
        {
            ticketPrice = 200;
        }
        
        if (timeOfDay == "PM")
        {
            ticketPrice += 50;
        }
        
        if (dayOfWeek == "saturday" || dayOfWeek == "sunday")
        {
            ticketPrice += 30;
        }
        
        Console.WriteLine($"Your ticket price is: ₱{ticketPrice}\n");
        
        Console.WriteLine("Problem 2: Snack Selection");
        Console.WriteLine("Choose a snack:");
        Console.WriteLine("1: Popcorn");
        Console.WriteLine("2: Soda");
        Console.WriteLine("3: Nachos");
        Console.WriteLine("4: Candy");
        Console.Write("Enter your choice (1-4): ");
        int snackChoice = int.Parse(Console.ReadLine());
        
        switch (snackChoice)
        {
            case 1:
                Console.WriteLine("Popcorn - Price: ₱80, Calories: 375");
                break;
            case 2:
                Console.WriteLine("Soda - Price: ₱65, Calories: 150");
                break;
            case 3:
                Console.WriteLine("Nachos - Price: ₱120, Calories: 560");
                break;
            case 4:
                Console.WriteLine("Candy - Price: ₱45, Calories: 230");
                break;
            default:
                Console.WriteLine("Invalid selection. Please choose 1-4.");
                break;
        }
        
        Console.WriteLine();
        
        Console.WriteLine("Problem 3: Entry Eligibility");
        Console.Write("Enter your age: ");
        int entryAge = int.Parse(Console.ReadLine());
        
        Console.Write("Do you have parental consent? (yes/no): ");
        string consentInput = Console.ReadLine().ToLower();
        bool hasConsent = consentInput == "yes";
        
        Console.Write("Do you have ID? (yes/no): ");
        string idInput = Console.ReadLine().ToLower();
        bool hasId = idInput == "yes";
        
        if (entryAge >= 18)
        {
            if (hasId)
            {
                Console.WriteLine("Allowed");
            }
            else
            {
                Console.WriteLine("Not allowed");
            }
        }
        else
        {
            if (hasConsent && hasId)
            {
                Console.WriteLine("Allowed with guardian");
            }
            else
            {
                Console.WriteLine("Not allowed");
            }
        }
        
        Console.WriteLine("\npress enter to exit");
        Console.ReadLine();
    }
}