public class MathAssignment : Assignment
{
    private String _textBookSection;
    private String _MathProblems;

    public MathAssignment(String name, String topic, String textBookSection, String mathProblems) : base(name, topic)
    {
        _textBookSection = textBookSection;
        _MathProblems = mathProblems;
    }

    public String GetHomeworkList()
    {
        return $"{_textBookSection}: {_MathProblems}";
    }


}