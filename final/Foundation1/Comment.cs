public class Comment
{
    public string _commenterName;
    public string _commenterText;

    public Comment(string commenterName, string commenterText)
    {
        _commenterName = commenterName;
        _commenterText = commenterText;
    }
    
    public string DisplayCommentDetails()
    {
        return $"{_commenterName}: '{_commenterText}'";
    }
}