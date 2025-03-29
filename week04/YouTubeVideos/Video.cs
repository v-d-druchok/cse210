public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public int GetComentNum()
    {
        return _comments.Count;
    }

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }


    public string GetDisplayText()
    {   
        string displayText = $"Title: {_title}, Author: {_author}, Length(seconds): {_length}, Number of Comments: {GetComentNum()} \nComments:\n";

        foreach (Comment comment in _comments)
        {
            displayText += $"{comment.FormatComment()}\n";
        }

        return displayText;
    }
}