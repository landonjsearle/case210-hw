using System.IO;

public class Journal
{
    public List<Entry> __entries = new List<Entry>();

    public void Save(String file_name)
    {
        using(StreamWriter file = new StreamWriter(file_name))
        {
            foreach (Entry entry in __entries)
            {
                file.WriteLine(entry.__date);
                file.WriteLine(entry.__prompt);
                file.WriteLine(entry.__entry);
            }
        }
    }
    public void Load(String file_name)
    {
        String[] lines = System.IO.File.ReadAllLines(file_name);

        int index = 0;
        foreach (String line in lines)
        {
            __entries[index].__date = line;
            __entries[index].__prompt = line;
            __entries[index].__entry = line;
            index++;
        }
    }
    public void Display()
    {
        foreach (Entry entry in __entries)
        {
            Console.WriteLine($"[{entry.__date}] {entry.__prompt}");
            Console.WriteLine(entry.__entry);
        }
    }
    public void AddEntry(Entry entry)
    {
        __entries.Append(entry);
    }
}