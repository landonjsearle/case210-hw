public class Words
{
    private String _Word;
    private Boolean _isHidden = false;

    public Words(String word)
    {
        _Word = word;
    }
    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }
    public Boolean IsHidden()
    {
        return _isHidden;
    }
    public String GetDisplayText()
    {
        String wordReturn = "";

        if (_isHidden)
        {           
            foreach (char c in _Word)
            {
                wordReturn =  wordReturn + "_";
            }
        }
        else 
        {
            wordReturn = _Word + " "; 
        }

        return wordReturn;
    }
}