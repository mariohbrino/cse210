using System;

class Program
{
    private static List<Video> _videos = [];
    private static List<Comment> _comments = [];

    static void Main(string[] args)
    {
        _videos.AddRange([
            new Video("The Art of Coding", "John Smith", 300),
            new Video("Understanding AI", "Jane Doe", 450),
            new Video("Top 10 Programming Tips", "Chris Johnson", 600),
            new Video("History of Computers", "Emily Davis", 720),
            new Video("Mastering C#", "Michael Brown", 540),
            new Video("Debugging Like a Pro", "Sarah Wilson", 480),
        ]);

        _comments.AddRange([
            new Comment("John Smith", "Great video, learned a lot!"),
            new Comment("Jane Doe", "This was super helpful, thanks!"),
            new Comment("Chris Johnson", "Loved the tips, very practical."),
            new Comment("Emily Davis", "Amazing explanation, so clear!"),
            new Comment("Michael Brown", "This is exactly what I needed."),
            new Comment("Sarah Wilson", "Fantastic content, keep it up!"),
            new Comment("Alex Carter", "Could you explain more about AI?"),
            new Comment("Lisa White", "Thanks for sharing this!"),
            new Comment("Tom Harris", "Very informative, great job!"),
            new Comment("Anna Lee", "Loved the debugging tips!"),
            new Comment("David Clark", "This was so easy to follow."),
            new Comment("Sophia Green", "Can you make a video on Python?"),
            new Comment("James Hall", "Really enjoyed this, thanks!"),
            new Comment("Olivia Scott", "Helpful and concise, great work!"),
            new Comment("Liam Wright", "Looking forward to more videos!"),
            new Comment("Emma King", "This was super insightful!"),
            new Comment("Noah Adams", "Thanks for the detailed tips!"),
            new Comment("Ava Baker", "Great explanation, very clear."),
            new Comment("Mason Turner", "Loved the history part!"),
            new Comment("Isabella Hill", "This was so well done!"),
            new Comment("Ethan Lewis", "Can you cover more on C#?"),
            new Comment("Mia Walker", "This helped me a lot, thanks!"),
            new Comment("Lucas Young", "Great examples, very useful."),
            new Comment("Charlotte Allen", "Loved the coding tips!"),
            new Comment("Elijah Martin", "This was so interesting!"),
            new Comment("Amelia Perez", "Thanks for the great video!"),
            new Comment("Benjamin Rivera", "Very clear and concise!"),
            new Comment("Harper Torres", "This was super helpful!"),
            new Comment("Jack Ramirez", "Looking forward to more!"),
            new Comment("Ella Sanchez", "Loved the debugging part!"),
        ]);

        int trackIndex = 0;
        foreach (Video video in _videos)
        {
            int index = 0;
            for (int commentIndex = trackIndex; commentIndex < _comments.Count; trackIndex++)
            {
                if (index < 5)
                {
                    video.SetComment(_comments[trackIndex]);
                }
                else
                {
                    break;
                }
                index++;
            }

            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Time: {video.GetLengthSeconds()} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  - author: {comment.GetPersonName()}");
                Console.WriteLine($"    message: {comment.GetMessage()}");
                Console.WriteLine("");
            }
            Console.WriteLine("");
        }
    }
}