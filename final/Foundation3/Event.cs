using System;


public class Event {



      private string event_name;
    private string event_description;
    private string event_date;

    private string event_time;
    private string event_address;

    




    public string choose_event_title() {
        Console.WriteLine ("1.what is your event title?");
        string event_title = Console.ReadLine ();
        return event_title;
    }

     

    public string choose_event_description() {
        Console.WriteLine("2. what is the event about?");
        string event_description = Console.ReadLine();
        return event_description;
    }
  
    public string choose_event_date() {
        Console.WriteLine("3.what is the date for the event?");
        string event_date = Console.ReadLine();
        return event_date;
    }
    public int choose_event_time() {
        Console.WriteLine("4. when does the event start?");
        int event_time = Console.Read();
        return event_time;
    }
    public string choose_event_address() {
        Console.WriteLine("5. where is the event?");
        string event_address = Console.ReadLine();
        return event_address;
    }
    



 Console.Write("Please enter filename--> ");
                        string fileName = Console.ReadLine();
                        string[] lines = System.IO.File.ReadAllLines(fileName);
                        foreach (string line in lines) {
                            string[] parts = Line.Split(",");

                            int points = int.Parse(parts[0]);
                            string choose_event_title = parts[1];
                            parts1 = choose_event_title
                            string choose_event_description = parts[2];
                            string choose_event_time = parts[3];
                            string enter_event_address = parts[4];
                            string choose_weather_type = parts[5];
                          string load_oder_file = parts[6];     }
            }

}