using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();
        Console.Write("What is your last name? ");
        string lastname = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine($"Your name is {lastname}, {firstName} {lastname}.");
    }
}