public class Comment
{
    private String _name;
    private String _text;

    public Comment(String name, String text)
    {
        _name = name;
        _text = text;
    }

    public String DisplayComment()
    {
        String display = $"{_name}: {_text}";

        return display;
    }
    public String GetName()
    {
        return _name;
    }
    public String GetText()
    {
        return _text;
    }
}