public class PromptGenerator
{
    public List<string> _prompts = new List<string>{
        "What did you struggle with the most today?",
        
        "What did you regret most today?",

        "What was the most interesting thing you did today?",      
    
        "What places did you visit today?",        
    
        "Who was the person that annoyed you most today?",     
    
        "What is something you couldn't do or finish today?",  
            
        "How was the weather today?",      
    
        "What saddened you the most today?",       
    
        "What brought you the most joy today?"
    };

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