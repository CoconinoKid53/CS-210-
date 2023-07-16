using System;
using System.IO; 

 public class video_comments {
    List <string> prompts = new List<string> {
        "who is the comment_author?",
        "what is The comment_description?"
        
    };


    public List<string> make_video_comments() {
        Console.WriteLine("4.make video_comments"); // prompt the user       
        string video_comments = Console.ReadLine(); 

        Console.WriteLine ("provide author");
        string comment_author = Console.ReadLine();

        List <string> return_values = new List<string> {
            video_comments, comment_author
        };
        return return_values;
        
    


}
    public void save_video_data() {
   Console.WriteLine("5.what is the name of the file?");// prompt
   string fileName = Console.ReadLine();
    


    using (StreamWriter outputFile = new StreamWriter(fileName))
{
        // You can add text to the file with the WriteLine method
        outputFile.WriteLine("This will be the first line in the file.");
    
        // You can use the $ and include variables just like with Console.WriteLine
        string color = "Blue";
        outputFile.WriteLine($"My favorite color is {color}");
    }
    }

public void load_video_file() {

    Console.WriteLine("6. what is the name of the file you wnat to load?");
    string fileName = Console.ReadLine();

string[] lines = System.IO.File.ReadAllLines(fileName);

foreach (string line in lines)
{
    // string[] parts = line.Split(",");

    // string firstName = parts[0];
    // string lastName = parts[1];

}
 Console.Write("Please enter filename--> ");
                string filename = Console.ReadLine();
                string[] Lines = System.IO.File.ReadAllLines(fileName);
                 foreach (string line in lines) {
                    string[] parts = line.Split(",");

                    int points = int.Parse(parts[0]);
                    string choose_video_author = parts[1];
                    string choose_video_title = parts[2];
                    string choose_video_time = parts [3];
                    string make_video_comments = parts[4];
                    string save_video_data = parts[5];
                    string load_video_file = parts[6];
}
}

 //public List<video_comments> GetVideo_Comments() {
           // return comments;
        



}

 