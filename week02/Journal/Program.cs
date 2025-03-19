using System;
using System.Diagnostics;
using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {

        /* 
            I added an exta part of the program that will look for an exeption when the file can not be found so that the program doesn't crash
            and will inform the user that the file was not found. It will also keep the program looping untill the user quits the program.
        */

        Console.WriteLine("Hello World! This is the Journal Project.");

        Journal myJournal = new Journal();

        Boolean done = false;
        do
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Load Journal");
            Console.WriteLine("4. Save Journal");
            Console.WriteLine("5. Quit Program");

            String response = Console.ReadLine();
            Console.WriteLine();
            if (response == "1")
            {
                Entry newEntry = new Entry();

                PromptGenerator promptGenerator = new PromptGenerator();
                newEntry.__prompt = promptGenerator.GeneratePrompt();

                Console.WriteLine($"Prompt: {newEntry.__prompt}");
                newEntry.__entry = Console.ReadLine();

                DateTime theCurrentTime = DateTime.Now;
                newEntry.__date = theCurrentTime.ToShortDateString();

                myJournal.AddEntry(newEntry);
                
                Console.WriteLine();
                Console.WriteLine();
            }
            else if (response == "2")
            {
                myJournal.Display();
                
                Console.WriteLine();
                Console.WriteLine();
            }
            else if (response == "3")
            {
                Console.WriteLine("What is the name of the file? (File Name.txt)");
                String fileName = Console.ReadLine(); 

                myJournal.Load(fileName);
                
                Console.WriteLine();
                Console.WriteLine();
            }
            else if (response == "4")
            {
                Console.WriteLine("What is the name of the file? (File Name.txt)");
                String fileName = Console.ReadLine(); 

                myJournal.Save(fileName);

                Console.WriteLine();
                Console.WriteLine();
            }
            else if (response == "5")
            {
                Console.WriteLine("Thank You!");
                done = true;
            }
            else
            {
                Console.WriteLine($"Invalid response: <{response}>");
                Console.WriteLine("Please type in the number next to the action you want to do.");
                Console.WriteLine();
                Console.WriteLine();

            }
        } while (done == false);
    }
}