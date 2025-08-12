using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Mini HR Program\n");

        Console.Write("Years of experience: ");
        int years = int.Parse(Console.ReadLine());

        Console.Write("Has degree? (yes/no): ");
        bool hasDegree = Console.ReadLine().ToLower() == "yes";

        Console.Write("Skill rating (1-5): ");
        int skill = int.Parse(Console.ReadLine());

        string status;
        if (years >= 2 && hasDegree && skill >= 4)
        {
            status = "Qualified";
        }
        else if (years >= 1 && skill >= 3)
        {
            status = "Borderline";
        }
        else
        {
            status = "Not Qualified";
        }
        Console.WriteLine("Candidate Status: " + status + "\n");

        Console.WriteLine("Pick a Job:");
        Console.WriteLine("1 - Developer");
        Console.WriteLine("2 - Designer");
        Console.WriteLine("3 - QA Tester");
        Console.WriteLine("4 - Project Manager");
        Console.Write("Enter 1-4: ");
        int job = int.Parse(Console.ReadLine());

        if (job == 1)
            Console.WriteLine("Developer - Make software");
        else if (job == 2)
            Console.WriteLine("Designer - Make things look good");
        else if (job == 3)
            Console.WriteLine("QA Tester - Test software");
        else if (job == 4)
            Console.WriteLine("Project Manager - Manage projects");
        else
            Console.WriteLine("Invalid choice");

        Console.WriteLine();

        Console.Write("Day (weekday/weekend): ");
        string day = Console.ReadLine().ToLower();

        Console.Write("Time (morning/afternoon): ");
        string time = Console.ReadLine().ToLower();

        Console.Write("Remote? (yes/no): ");
        bool remote = Console.ReadLine().ToLower() == "yes";

        string slot;
        if (day == "weekday")
        {
            if (time == "morning" && remote)
                slot = "Slot A";
            else if (time == "afternoon" && !remote)
                slot = "Slot B";
            else
                slot = "No slot available";
        }
        else if (day == "weekend")
        {
            slot = "Slots full";
        }
        else
        {
            slot = "Invalid day";
        }

        Console.WriteLine("Interview Slot: " + slot);

        Console.WriteLine("\nPress Enter to exit");
        Console.ReadLine();
    }
}
