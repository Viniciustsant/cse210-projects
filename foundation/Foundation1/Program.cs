using System;

class Program
{
    static void Main(string[] args)
    {

        Video video1 = new Video("Learning C#", "DeveloperCast", 356);
        Video video2 = new Video("Aprendendo C#", "DesenvolvedorCast", 254);
        Video video3 = new Video("C# in real life", "Video Teacher", 452);

        Comment comment1 = new Comment("Vinicius Santiago", "Very good video, i learned so much");
        Comment comment2 = new Comment("Esther Sales", "Muito bom o video, aprendi bastante");
        Comment comment3 = new Comment("Ayla Santiago", "Very usefull info, this helped me a lot");
        Comment comment4 = new Comment("Maya Santiago", "Video muito importante, me ajudou demais");
        Comment comment5 = new Comment("Alexandre Santiago", "I really liked this video");
        Comment comment6 = new Comment("Michelle Santiago", "Essa explicação de abstração foi otima");
        Comment comment7 = new Comment("Isabel Santiago", "This explanation about abstration was amazing");
        Comment comment8 = new Comment("Abby Santiago", "Ótima aula dada pelo professor");
        Comment comment9 = new Comment("Nicolas Santiago", "It gave me more informations that i thought that was possible");

        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);

        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);

        video3.AddComment(comment7);
        video3.AddComment(comment8);
        video3.AddComment(comment9);

        foreach (Video video in new List<Video> {video1, video2, video3})
        {
            Console.WriteLine($"\nTitle: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Duaration: {video.GetDuration()}");
            Console.WriteLine($"Number of comments: {video.GetCommentCount()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"\nComment of {comment.GetName()}: {comment.GetText()}");
            }
            Console.WriteLine("-------------------------------");
        }
    }
}