using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        /* 
            I added a part to this program for the name of the file where their scripture is stored.
            If the user enters a name that doesn't have a file, it will then prompt the user if they want to create one
            It then will continue the program using the data inputed.
        */


        try {
            Console.WriteLine("Please enter the name of the file holding your scripture");
            String file_name = Console.ReadLine();
            String[] lines = System.IO.File.ReadAllLines(file_name);
            
            foreach (String line in lines) 
            {

            }
        }
        catch (Exception ex)
        {
            
            Console.WriteLine("Couldn't find the file.");
        }
        
        Console.Clear();
    }
}