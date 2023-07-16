using System;


public class lecture_name {

    private  string speaker_name;
    private string lecture_topic;
    private int limited_capacity;
    public string enter_speaker_name() {
         Console.WriteLine("6.what is the speakers name?");
         string speaker_name = Console.ReadLine();
         return speaker_name;
    }
    public string enter_lecture_topic() {
        Console.WriteLine("7.What is the lecture about?");
        string lecture_topic = Console.ReadLine();
        return lecture_topic;
    }
   public int enter_limited_capacity() {
    Console.WriteLine("8.how many people can attend the lecture?");
    int limited_capacity = Console.Read();
    return limited_capacity;
   }
}