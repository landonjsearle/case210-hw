public class Scripture
{
    private Reference _reference;
    private List<Words> _words = new List<Words>();


    public Scripture(Reference reference, String text)
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
        int numberOfWords = _words.Count;
        Random random = new Random();

        //Console.WriteLine($"Hiding {numberToHide} words.");
        for (int i = 0; i < numberToHide; i++)
        {
            int hide = random.Next(0, numberOfWords);
            if (_words[hide].IsHidden())
            {
                i--;
            }
            else
            {
                _words[hide].Hide();
            }
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