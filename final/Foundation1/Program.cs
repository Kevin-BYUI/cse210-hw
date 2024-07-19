using System;

class Program
{
    
    static void Main(string[] args)
    {
    // This shows a list of names alongside the comments they made.
        Comment comment = new Comment("Kevin Ouma Ogutu", "That was hard!");
        Comment comment1 = new Comment("Harvey Michael Ouma", "wish he continued talking a little longer!");
        Comment comment2 = new Comment("Jurdine Ruth Peryl", "Can't waait to watch Part 2");
        Comment comment3 = new Comment("Joseph Carlos", "That was the plan? Fantastic!");
        Comment comment4 = new Comment("John Brandon", "Damn it!");
        Comment comment5 = new Comment("Jeff Twains", "I cant do that");
        Comment comment6 = new Comment("Justne Vam", "And that is is!");
        Comment comment7 = new Comment("James Sky", "She got the way");
        Comment comment8 = new Comment("Rihanna Daniels", "Wicked!");
        Comment comment9 = new Comment("Dianna Reins", "Can't do that either");
        Comment comment10 = new Comment("Jerry Williama", "It dawned on him");
        Comment comment11 = new Comment("John Smith", "That was amazing!");
        Comment comment12 = new Comment("Emily Johnson", "Loved the storyline!");
        Comment comment13 = new Comment("Sarah Davis",  "It was a bit predictable.");
        Comment comment14 = new Comment("Matthew Thomas", "Definitely worth watching!");
        Comment comment15 = new Comment("Christopher White", "The cinematography was beautiful.");
        Comment comment16 = new Comment("Ashley Harris", "I can't wait for the sequel!");
        Comment comment17 = new Comment("Andrew Martin", "The ending was perfect.");
        Comment comment18 = new Comment("Elizabeth Thompson", "A bit too slow for my taste.");
        Comment comment19 = new Comment("Joshua Lewis", "The soundtrack was awesome.");

    // This section shows video objects and what the arguments they accept.  
        Video video = new Video("The Chronicles", "James Bradley", 90);
        Video video1 = new Video("The Stammers", "Joseph Brod", 100);
        Video video2 = new Video("No Time To Waste", "Jack Stevens", 95);
        Video video3 = new Video("Got It Wrong", "David Bradley", 120);
        Video video4 = new Video("The Crying Soul", "Jerry Toms", 150);

    // each comment added to the respective video
        video.AddComment(comment);
        video.AddComment(comment4);
        video.AddComment(comment7);
        video.AddComment(comment10);
    
        video1.AddComment(comment1);
        video1.AddComment(comment3);
        video1.AddComment(comment13);
        video1.AddComment(comment12);

        video2.AddComment(comment2);
        video2.AddComment(comment5);
        video2.AddComment(comment6);
        video2.AddComment(comment9);

        video3.AddComment(comment8);
        video3.AddComment(comment19);
        video3.AddComment(comment14);
        video3.AddComment(comment11);

        video4.AddComment(comment15);
        video4.AddComment(comment16);
        video4.AddComment(comment17);
        video4.AddComment(comment18);

    // a list of video objects
        List<Video> youTubeVideos = new List<Video> {video, video1, video2, video3, video4};
        foreach (Video youTubeVideo in youTubeVideos)
        {
            Console.WriteLine();
            youTubeVideo.DisplayVideoInformation();        
        }    
    }
}