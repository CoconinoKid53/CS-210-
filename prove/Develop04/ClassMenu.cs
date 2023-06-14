class ClassMenu {

    public string GetInput() {
        // displayin the menu


        while (true){
        // displayin the menu
        Console.WriteLine   ("1: Display Breathing Activity");
        Console.WriteLine   ("2: Display reflecting activity"); 
        Console.WriteLine   ("3: Display listing activity ");
        Console.WriteLine ("Choose from the following options?");
        string activity =  Console.ReadLine  ();
        if (activity == "1"){
             
            var breathe = new Breathing();
            breathe.BreathingActivity();
            
        Console.WriteLine (" when do you want to stop the activity?");
            var duration = Console.ReadLine();
            
        }
        if (activity == "2") {
            var reflecting = new Reflecting();
            reflecting.do_activity();
        }
        if (activity == "3") {
            var listing = new Listing ();
            listing.do_activity();

        }
        }

        // prompt the user
        
        return "activity";

    }
    
}