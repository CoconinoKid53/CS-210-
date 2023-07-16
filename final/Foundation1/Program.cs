using System;

class Program
{
    static void Main(string[] args)

    {

        var video_title = new Video();
        var video_author = new Video();
        var video_comments = new Video();
        var video_time_length = new Video();
        List<Video> videos = new List<Video>{video_title ,video_author ,video_comments ,video_time_length };

        

        foreach  (Video v in videos){
            Console.WriteLine("Author:{0}",v.Getvideoauthor());

        foreach (video_comments c in v.GetVideo_Comments()){
            Console.WriteLine("Comments:{0}",v.GetVideo_Comments());
        }
        }


  
  

       
    }

}