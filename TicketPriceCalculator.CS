using System;

public class TicketPriceCalculator
{
    public static void CalculateTicketPrice()
    {
        Console.WriteLine("Enter your age:");
        int age = Convert.ToInt32(Console.ReadLine());

        decimal ticketPrice = CalculatePrice(age);

        Console.WriteLine($"Your ticket price is: GHC {ticketPrice}");
    }

    private static decimal CalculatePrice(int age)
    {
        const decimal standardPrice = 10;
        const decimal discountedPrice = 7;

        if (age <= 12 || age >= 65)
            return discountedPrice;
        else
            return standardPrice;
    }
}
