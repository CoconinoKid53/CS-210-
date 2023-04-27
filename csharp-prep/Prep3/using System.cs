using System;

 class Program
 {
    static void Main(string [] args)
    {

        var numbers = new List<int>();

        while (true) {


            Console.Write("please enter a number ");

            int number = int.Parse(Console.ReadLine());

            if (number == 0) {
                break;
            }

            numbers.Add(number);
        }
        int sum = 0;
        foreach (var item in numbers) {
            sum += item;
            
        }
        Console.WriteLine(sum);
            
        }
    }
 }