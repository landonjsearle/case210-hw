public class Stripture
{
    private Reference _reference;
    private List<Words> _words = new List<Words>();
    

    public Stripture(Reference reference, String text)
    {
        _reference = reference;

        String[] words = text.Split();
        words = text.Split(" ");

        foreach (String word in words)
        {
            Words newWord = new Words(word);
            _words.Add(newWord);
        }
    }

    public void HideRandomWords(int numberToHide)
    {

        Console.WriteLine($"Hiding {numberToHide} words.");
        for (int i = 0; i < numberToHide; i++)
        {
            _words[i].Hide();
        }
    }

    public String GetDisplayText()
    {
        String display = $"{_reference.GetDisplayText}:\n" ; // Adds the reference to the display varialbe

        foreach (Words word in _words)
        {
            display += word.GetDisplayText();
        }

        return display;
    }

    public Boolean IsCompletelyHidden()
    {
        int numberVisible = 0;

        foreach (Words word in _words)
        {
            if (word.IsHidden() == false)
            {
                numberVisible += 1;
            }
        }

        if (numberVisible == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}