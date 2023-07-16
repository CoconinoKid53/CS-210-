using System;


public class outdoor_event {

    private string outdoorevent;

    private string emailrsvp;
    
    private string weather_type;

    public string choose_outdoor_event() {
        Console.WriteLine("9. is this event an outdoor event?");
        string outdoor_event = Console.ReadLine();
        return outdoor_event;
    }
    public class email_rsvp {
        private string enter_email_rsvp() {
            Console.WriteLine("10. how many people do you want to attend?");
            string rsvp_email = Console.ReadLine();
            return rsvp_email;
        }
    }
    public class enter_weather_type {
        private string weather_type() {
            Console.WriteLine("11. what will the weather be for the event?");
            string weather = Console.ReadLine();
            return weather;
        }
    }
}