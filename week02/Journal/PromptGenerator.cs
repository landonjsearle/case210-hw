using System;

public class PromptGenerator
{
    public List<String> __prompts = new List<string>  {
        "Who was the most interesting person I interacted with today?", "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?", "How have I lived like my Savior Jesus Christ?",
        "What stories have you thought about today?", "Do you have any new intresting ideas?", "Say 5 good things about yourself!",
        "Explain why you are a good person. (You have to be positive about yourself.)", "How can you help your family today?"
    };

    public String GeneratePrompt()
    {
        Random random = new Random();

        // Used to see the numbers being generated. Used for testing.

        // for (int i = 0; i < 100; i++)
        // {
        // int number = random.Next(0, __prompts.Count - 1);
        // Console.WriteLine(number);
        // }

        int index = random.Next(0, __prompts.Count - 1);
        return __prompts[index];
    }
}