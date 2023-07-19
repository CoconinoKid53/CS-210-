using System;

class Program
{
    static void Main(string[] args)

    {

        var Video1 = new Video("What I learned from taking a train across the US", "Vox", 13f);
        Video1.AddComment(new Comment("@itsapersonn", "My brother's a car guy, and even he would prefer high speed trains over driving a car in traffic. Goes to show how much worse cities in the US and Canada have become since the 1950s."));
        Video1.AddComment(new Comment("@randomuserxoxo", "Taking a train across the States must’ve been an exhilarating experience. You’re not restricted to simply flying as a passenger on the plane or taking your car for a road trip."));
        Video1.AddComment(new Comment("@angelromero00o", "Amtrak is a hidden gem. If you have the extra time, it’s worth it"));
        Video1.AddComment(new Comment("@MasonsTurtle", "Experience public transportation in Taiwan, China, and even London makes we wish the US had similar."));
       
        var Video2 = new Video("", "", 0f);
        var Video3 = new Video("", "", 0f);
        var Video4 = new Video("", "", 0f);
        List<Video> videos = new List<Video>{Video1 ,Video2 ,Video3 ,Video4 };

        

        foreach  (Video v in videos){
            Console.WriteLine("Title: {0}",v.GetTitle());
            Console.WriteLine("Author: {0}",v.GetAuthor());
            Console.WriteLine("Length: {0} minutes",v.GetLength());
            Console.WriteLine();
            Console.WriteLine("Comments:");

            foreach (Comment c in v.GetComments()){
                Console.WriteLine();
                Console.WriteLine(c.GetAuthor());
                Console.WriteLine(c.GetContent());
            }
            Console.WriteLine();
        }


  
  

       
    }

}