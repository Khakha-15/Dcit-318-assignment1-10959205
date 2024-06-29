using System;

class TicketPriceCalculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your age:");
        int age = Convert.ToInt32(Console.ReadLine());

        decimal ticketPrice = CalculateTicketPrice(age);

        Console.WriteLine($"Your ticket price is: GHC {ticketPrice}");
    }

    static decimal CalculateTicketPrice(int age)
    {
        const decimal standardPrice = 10;
        const decimal discountedPrice = 7;

        if (age <= 12 || age >= 65)
            return discountedPrice;
        else
            return standardPrice;
    }
}