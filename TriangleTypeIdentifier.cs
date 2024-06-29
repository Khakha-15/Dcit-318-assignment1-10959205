using System;

public class TriangleTypeIdentifier
{
    public static void IdentifyTriangleType()
    {
        Console.WriteLine("Enter the length of side 1 of the triangle:");
        double side1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the length of side 2 of the triangle:");
        double side2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the length of side 3 of the triangle:");
        double side3 = Convert.ToDouble(Console.ReadLine());

        string triangleType = DetermineTriangleType(side1, side2, side3);

        Console.WriteLine($"The triangle type is: {triangleType}");
    }

    private static string DetermineTriangleType(double side1, double side2, double side3)
    {
        if (side1 == side2 && side2 == side3)
            return "Equilateral";
        else if (side1 == side2 || side1 == side3 || side2 == side3)
            return "Isosceles";
        else
            return "Scalene";
    }
}
