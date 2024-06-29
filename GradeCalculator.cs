using System;

public class GradeCalculator
{
    public static void CalculateGrade()
    {
        Console.WriteLine("Enter your numerical grade (0-100):");
        int grade = Convert.ToInt32(Console.ReadLine());

        char letterGrade = DetermineLetterGrade(grade);

        Console.WriteLine($"Your letter grade is: {letterGrade}");
    }

    private static char DetermineLetterGrade(int grade)
    {
        if (grade >= 90)
            return 'A';
        else if (grade >= 80)
            return 'B';
        else if (grade >= 70)
            return 'C';
        else if (grade >= 60)
            return 'D';
        else
            return 'F';
    }
}
