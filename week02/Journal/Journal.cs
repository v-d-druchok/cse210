using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    
    
    public void AddEntry(Entry newEntry)  {
        _entries.Add(newEntry);
    }

    public void DisplayAll() {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void Save(string file) {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._promptText}|~|{entry._entryText}|~|{entry._date}");
            }
        }
    }

    public void Load(string file) {
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|~|");

            Entry loaded = new Entry();

            loaded._promptText = parts[0];
            loaded._entryText = parts[1];
            loaded._date = parts[2];

            _entries.Add(loaded); 
        }
    }

}