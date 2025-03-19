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
                file.WriteLine($"{entry.__date}~{entry.__prompt}~{entry.__entry}");
            }
        }

        Console.WriteLine("Journal Saved");
    }

    public void Load(String file_name)
    {
        try{
            String[] lines = System.IO.File.ReadAllLines(file_name);

            __entries.Clear();

            int index = 0;
            foreach (String line in lines)
            {
                String[] lineParts = line.Split("~");

                Entry newEntry = new Entry();

                newEntry.__date = lineParts[0];
                newEntry.__prompt = lineParts[1];
                newEntry.__entry = lineParts[2];

                __entries.Add(newEntry);
                index++;
            }

            Console.WriteLine("Journal Loaded");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Could not find file, \"{file_name}\".");
            Console.WriteLine("Make sure you use the format, \"File Name.txt\"");
            Console.WriteLine(ex.Message);
        }
    }
    public void Display()
    {
        foreach (Entry entry in __entries)
        {
            entry.Display();
        }
    }
    public void AddEntry(Entry entry)
    {
        __entries.Add(entry);
    }
}