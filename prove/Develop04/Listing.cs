class Listing : Activity{
     List <string> prompts = new List<string>   {
        "Who are people that you appreciate?" ,
        "What are personal strengths of yours?" ,
        "Who are people that you have helped this week?" ,
        "When have you felt the Holy Ghost this month?" ,
        "Who are some of your personal heroes?" };
    public void Display_Instructions () {
        Console.WriteLine ("please choose a prompt");

    }
     public void Display_Instructionstwo () {
        Console.WriteLine ("Wait for ten seconds and ponder about the prompt");
    } 
    public void Display_Instructionsthree () {
        Console.WriteLine ("Keep choosing prompts and ponder on how great your life is");
    }
    public Listing () {
        type = "Listing";
        description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";


        // Steps for listing activity
      
    }
    public void ListingActivity () {

    }
      public void ListingActvity() {
        int duration = 6;
        int ListingDuration = 6;
       
         DateTime StartTime = DateTime.Now;
        DateTime FutureTime = StartTime.AddSeconds(duration);
          while (FutureTime>DateTime.Now) {
            Console.WriteLine("Listing");
        Countdown(ListingDuration);

        Console.WriteLine("Listing");
        Countdown(ListingDuration);
          }        

    }
    public void do_activity () {
        
        Random prompt = new Random ();
        int secondprompt = prompt.Next(4);
        Console.WriteLine(prompts[secondprompt] );
        string input = Console.ReadLine ();
        Console.WriteLine ("thank you for particpating the listing activity");

    }
   
}
