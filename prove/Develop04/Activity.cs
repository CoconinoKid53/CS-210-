class Activity{
    public string instructions;
    public string type;
    public string description;

     public int  _seconds;
    public void _descritption() {
        Console.WriteLine ($"Welcome to the {type} activity");
        Console.WriteLine (description);
        Console.Write("how long in sconds would you like your session?");
       
      _seconds = int.Parse( Console.ReadLine());
     


    }
    public void GetReady () {

    }
    public void _Show_instruction () {
        Console.WriteLine(instructions);
    }
    // public void do_activity(){} 
    public void end_activity() {
        Console.WriteLine("well done");
        Console.WriteLine ($"thank you for aparticipating in the {type}activity ");

    }
    public void do_animation(int countdown) {
        for (int i = 0; i < countdown; i++){
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b");
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