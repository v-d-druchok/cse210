public class Comment 
{
    private string _userName;
    private string _comment;

    public Comment(string name, string content)
    {
        _userName = name;
        _comment = content;
    }

    public string FormatComment()
    {
        return $"{_userName}, commented: {_comment}";
    }
}