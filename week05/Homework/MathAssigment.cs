public class MathAssigment : Assigment
{
    private string _textbookSection;
    private string _problems;

    public MathAssigment(string name, string topic, string section, string problems) : base(name, topic)
    {
        _textbookSection = section;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"section: {_textbookSection}, problems: {_problems}";
    } 
}