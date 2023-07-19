using System;


class Video {

    // attributes
    private string Author;
    private string Title;
    private float Length;

    List <Comment> Comments;

    public Video(string _title, string _author, float _time){

            Author = _author;
            Title = _title;
            Length = _time;

            Comments = new List<Comment>();
    }
    public string GetAuthor(){
        return Author;
    }

      public string GetTitle(){
        return Title;
    }
    public float GetLength() {
        return Length;
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public List<Comment> GetComments()
    {
        return Comments;
    }

 }
        








