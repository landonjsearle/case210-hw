using System;

public class PromptGenerator
{
    public List<String> __prompts = new List<string> {""};

    public String GeneratePrompt()
    {
        Random random = new Random();

        int index = random.Next(0, __prompts.Count);
        return __prompts[index];
    }
}