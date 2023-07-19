using System;
using System.IO; 

 public class Comment {

    private string Author;
    private string Content;

    public Comment(string author, string content) 
    {
        Author = author;
        Content = content;
    }
        
    public string GetAuthor()
    {
        return Author;
    }

    public string GetContent()
    {
        return Content;
    }
}

 