using System;
using System.Collections.Generic;


public class Video
{
    private string Title;
    private string Author;
    private int Duration;
    private List<Comment> Comments;


    public Video (string title, string author, int duration)
    {
        Title = title;
        Author = author;
        Duration = duration;
        Comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public string GetTitle()
    {
        return Title;
    }
    public string GetAuthor()
    {
        return Author;
    }
    public int GetDuration()
    {
        return Duration;
    }
    public int GetCommentCount()
    {
        return Comments.Count;
    }
    public List<Comment> GetComments()
    {
        return Comments;
    }

}