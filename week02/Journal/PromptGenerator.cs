public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public string GetRandomPrompt() {

        Random rnd = new Random();

        int i = rnd.Next(_prompts.Count);

        string _prompt = _prompts[i];

        return _prompt;
       
    }

    public void AddPrompt(string prompt)  {
        _prompts.Add(prompt);
    }

    public void SavePrompts() {

        string file = "prompts.txt";
       
        using (StreamWriter outputFile = new StreamWriter(file))

        {
            foreach (string prompt in _prompts)
            {
                outputFile.WriteLine(prompt);
            }
        }
    }


    public void LoadPrompts() {
        
        string file = "prompts.txt";

        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            _prompts.Add(line);
        }
    }

}