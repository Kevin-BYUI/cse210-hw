public class Video
{
    public string _title;
    public string _author;
    public int _videoLengthInSeconds;
    public List<Comment> _comments;

    public Video(string title, string author, int videoLengthInSeconds)
    {
        _title = title;
        _author = author;
        _comments = new List<Comment>();
        _videoLengthInSeconds = videoLengthInSeconds;     
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void DisplayVideoInformation()
    {
        Console.WriteLine($"Video Title: {_title}");
        Console.WriteLine($"Video Author: {_author}");
        Console.WriteLine($"Length Of Video (seconds): {_videoLengthInSeconds}");
        Console.WriteLine($"Number of Comments: {NumberOfComments()}");
        Console.WriteLine("Comments:");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"-{comment.DisplayCommentDetails()}");  
        }     
    }

    public int NumberOfComments()
    {
        return _comments.Count;
    }
}