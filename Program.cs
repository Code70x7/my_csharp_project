//this is my first program
// you better believe it. Learning source control.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to my first C# console app!");

        Console.Write("What is your name? ");
        string name = Console.ReadLine();

        Console.Write("How old are you? ");
        string age = Console.ReadLine();

        Console.WriteLine($"\nNice to meet you, {name}! You are {age} years old.");
    }
}
