using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Choose an application to run:");
            Console.WriteLine("1. Grade Calculator");
            Console.WriteLine("2. Ticket Price Calculator");
            Console.WriteLine("3. Triangle Type Identifier");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice (1-4): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    RunGradeCalculator();
                    break;
                case 2:
                    RunTicketPriceCalculator();
                    break;
                case 3:
                    RunTriangleTypeIdentifier();
                    break;
                case 4:
                    Console.WriteLine("Exiting the program.");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number from 1 to 4.");
                    break;
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }

    static void RunGradeCalculator()
    {
        Console.WriteLine("\nRunning Grade Calculator...");
        GradeCalculator.CalculateGrade();
    }

    static void RunTicketPriceCalculator()
    {
        Console.WriteLine("\nRunning Ticket Price Calculator...");
        TicketPriceCalculator.CalculateTicketPrice();
    }

    static void RunTriangleTypeIdentifier()
    {
        Console.WriteLine("\nRunning Triangle Type Identifier...");
        TriangleTypeIdentifier.IdentifyTriangleType();
    }
}
