using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        string scale = "";
        string status = "";
        //after the variable is entered we make an operation to know the last digit
        int lastDigit = grade % 10;
        string sign = "";

        if (grade >= 90)
        {
            scale = "A";
        }
        else if (grade >= 80)
        {
            scale = "B";
        }
        else if (grade >= 70)
        {
            scale = "C";
        }

        else if (grade >= 60)
        {
            scale = "D";
        }
        else
        {
            scale = "F";
        }

        if (grade >= 70)
        {
            status = "Good work! Keep going!";
        }
        else
        {
            status = "Try your best next time!";
        }
        // we use double equal == instead of in due to C# does not contain the in operator
        if (scale == "B" || scale == "C" || scale == "D" )
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
        }
        else if (scale == "A")
        {
            if (lastDigit >= 7)
            {
                sign = "";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
        }
        Console.WriteLine($"Your grade in the scale is {scale}{sign}.");
        Console.WriteLine();
        Console.WriteLine($"{status}");
    }
}