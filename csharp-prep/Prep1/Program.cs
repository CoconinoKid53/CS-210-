using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("what is your first name? ");
        string firstName = Console.ReadLine();

        Console.WriteLine("What is your last name? ");
        string lastName = Console.ReadLine();


        // Your Name is Guthrie, Dillon Guthrie.
        Console.WriteLine($"Your name is {lastName} , {firstName} {lastName}");
    }
}