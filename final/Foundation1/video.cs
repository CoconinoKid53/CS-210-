using System;


public class Video {

    // attributes
    private string video_author;
    private string video_title;
    private string video_time_length;

    List <video_comments> comments;


 





    public string  choose_video_author () {
        // making video_author function to declare
        Console.WriteLine ("1. choose video_author"); // lets user choose 
        // video_author.
        // after choosing the video_author
        video_author =  Console.ReadLine (); // lets the user choose 
        // vidoe authors name
        return video_author;
        
    }


    public string Getvideo_author(){
        return video_author;
    }
    // the purpose of this function is to let the user call the function
    //returning the video_title
    public string choose_video_title() {
        Console.WriteLine("2.choose video_title"); // lets user choose vidoe_title
         video_title = Console.ReadLine(); // lets user return video_title
        return video_title;

        
        


    }


      public string Getvideo_title(){
        return video_title;
    }
     public string choose_video_time() {
        Console.WriteLine("3.choose video_time_length"); // lets user choose vidoe_title
         video_time_length = Console.ReadLine(); // lets user return video_title
        return  video_time_length;
     }

        public string Getvideo_time_length() {
            return video_time_length;
        }

        
  


        
                public  Video(string title, string author, string time){

                        video_author = author;
                        video_title = title;
                        video_time_length = time;
                }

               


                //choose_video_author();
                //choose_video_title();
                //choose_video_time();

   
     }
        








