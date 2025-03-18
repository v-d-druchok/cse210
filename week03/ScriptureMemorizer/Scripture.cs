public class Scripture 
{   
    private Reference _reference; 
    private List<Word> _words= new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] words = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords (int numberToHide) 
    {
        Random random = new Random();

        for (int i = 0; i < numberToHide; i++)
        {   
            int index = random.Next(_words.Count);
            Word wordToHide = _words[index];
            if (!wordToHide.IsHidden())
            {
                wordToHide.Hide();
            }

            else
            {
                i -= 1;
            }
        }
    }

    public string GetDisplayText()
    {
        string text = $"{_reference.GetDisplayText()} ";

        foreach (Word word in _words)
        {
            text += word.GetDisplayText() + " ";
        }

        return text.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        
        return true;
    }
}