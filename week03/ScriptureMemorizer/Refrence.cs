public class Reference
{
    private String _book;
    private int _chapter;
    private int _verse;
    private int _endVerse = 0; // Is used to represent that there is no end verse. To display, there must be a value other then 0.
    


    public Reference(String book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    public Reference(String book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public String GetDisplayText()
    {

        String displayText;

        if (_endVerse == 0)
        {
            displayText = $"{_book} {_chapter}: {_verse}";
        }
        else
        {
            displayText = $"{_endVerse} {_chapter}: {_verse}-{_endVerse}";
        }


        return displayText;
    }
}