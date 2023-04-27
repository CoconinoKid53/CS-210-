using System;

class Program
{
    static void Main(string[] args)
    {
        Random generator = new Random();
        int magicNumber = generator.Next(1,101);

        int userGuess = -1;


        while (userGuess != magicNumber) {

            Console.WriteLine("Guess a Number: ");
            userGuess = int.Parse(Console.ReadLine());
           
        // If guess is higher than the number, print Lower

        // If guess is lower than the number, print Higher

        // If guess correctly, say "YAY"

        if (userGuess>magicNumber) {

            Console.WriteLine ("print Lower")

        

        } else if(userGuess<magicNumber) {
            Console.WriteLine ("Lower");
            
        }

     }

   }
}