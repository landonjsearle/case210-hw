using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        /*
            Exceedxs Requrements:
            Added a part to the program to check to see if the word is already hidden when the program trys to hide a word.
        */
        
        Reference reference= new Reference("1 Nephi", 1, 1);
        Scripture scripture = new Scripture(reference, "1. I, Nephi, having been born of goodly parents, therefore I was taught somewhat in all the learning of my father; and having seen many afflictions in the course of my days, nevertheless, having been highly favored of the Lord in all my days; yea, having had a great knowledge of the goodness and the mysteries of God, therefore I make a record of my proceedings in my days.");
        
        Random randomNumber = new Random();

        Boolean end_program = false;

        do{
            
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            int hide = randomNumber.Next(1, 5);
            scripture.HideRandomWords(hide);
            Console.WriteLine("Press enter to contine. or type, \"quit\" to end the program.");
            String response = Console.ReadLine();
            if (response == "quit")
            {
                end_program = true;
            }
            else{
                end_program = scripture.IsCompletelyHidden();
            }

        } while (end_program == false);

    }
}
