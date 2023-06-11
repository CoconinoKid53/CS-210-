class Breathing : Activity{
    public Breathing () {
        type = "Breathing";
        description = "This activity will help you to relax and focus by breathing in and out slowly";
    }
   
    // step one : display instructions 
   
    public int Start_countdown () {
        return _seconds;
    }
    public void Display_Instructions () {
        Console.WriteLine ("Breathe in for a couple of seconds");

    }
    public void Display_Instructionstwo () {
        Console.WriteLine ("Wait for ten seconds");
    } 
    public void Display_Instructionsthree () {
        Console.WriteLine ("Breathe out for ten seconds");
    }

    public void BreathingActivity () {
         int duration = 27;
        int breatheInDuration = 4;
        int BreatheOutDuration = 6;
         DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);
         while (futureTime>DateTime.Now) {
        Console.WriteLine("Breathe In");
        Countdown(breatheInDuration);

        Console.WriteLine("Breathe Out");
        Countdown(BreatheOutDuration);

    }
    }
     
    
   

   
    public void Countdown(int duration) {
        int currentValue = duration; 
        
        while (currentValue > 0) {
            Console.WriteLine (currentValue);
            Thread.Sleep(1000);
            currentValue--;

        }
        currentValue--;

        }

}
    // duration 27

    // breathe in 4 seconds
    // breathe in 6 seconds

  
    // show end message
    // step two : display breathe in and wait for a period and 
    // write a function diplay_instruction
    // write a scope
    // define the return type
    // then display Console.WriteLine and display_instructions writing them down in parameters





    // step three : then display breathe out and wait another period.
    // step four : continue process until done
