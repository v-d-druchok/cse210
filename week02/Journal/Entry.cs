public class Entry
{
    static DateTime now = DateTime.Now;
    public string _date = now.ToString("MM/dd/yyyy hh:mm tt");
    public string _entryText;
    public string _promptText;

    public void Display() {
        Console.WriteLine($"\n Question: {_promptText}, \n Answer: {_entryText}, \n At: {_date}");
    }

}