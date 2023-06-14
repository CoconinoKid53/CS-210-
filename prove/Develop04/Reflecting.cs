class Reflecting : Activity{
    public Reflecting () {
        type = "Reflecting";
         description = "This activity will help you reflect on times in your life when you have shown strength and resilience. ";
    }

    List <string> prompts = new List<string> ()  {
        "Think of a time when you did something really difficult.",
        "Think of a time when you stood up for someone else.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    }; 
   
    // step one : display instructions 

    public void Display_Instructions () {
        Console.WriteLine ("Please select a prompt");

    }
    public void Display_Instructionstwo () {
        Console.WriteLine ("Wait for ten seconds");
    } 
    public void Display_Instructionsthree () {
        Console.WriteLine ("Reflect on the prompt  for ten seconds");
    }
    public void do_activity () {
        
        Random prompt = new Random ();
        int secondprompt = prompt.Next(4);
        Console.WriteLine(prompts[secondprompt] );
        string input = Console.ReadLine();

    }
    //DateTime = "ADDseconds"

    // step two : display breathe in and wait for a period and 
    // write a function diplay_instruction
    // write a scope
    // define the return type
    // then display Console.WriteLine and display_instructions writing them down in parameters





    // step three : then display breathe out and wait another period.
    // step four : continue process until done
    public void RefelctingActvity() {
        int duration = 12;
        int ReflectingDuration = 6;
        int ReflectionDuration = 6;
         DateTime StartTime = DateTime.Now;
        DateTime FutureTime = StartTime.AddSeconds (duration);
          while (FutureTime>DateTime.Now) {
            Console.WriteLine("Breathe In");
        Countdown(ReflectingDuration);

        Console.WriteLine("Reflect");
        Countdown(ReflectingDuration);
        Console.WriteLine ("thank you for particpating the reflecting activity");
        
          }
    }
}