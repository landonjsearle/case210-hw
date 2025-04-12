using System;

class Program
{
    static void Main(string[] args)
    {

        /*****************************************************
        I Exceed expections by adding a part to the program 
        that will track how many times each activity was used.
        It then will display at the end.
        *****************************************************/
        int breathed = 0;
        int listed = 0;
        int reflected = 0;

        Console.WriteLine("Hello World! This is the Mindfulness Project.");

/*      // Used for debugging
        Activity activity = new Activity();

        activity.SetDuration(100);

        activity.ShowSpinner(5);
        activity.ShowCountdown(3);

        // BreathingActivity breathingActivity= new BreathingActivity();
        // breathingActivity.Run();

        // ReflectionActivity reflectionActivity= new ReflectionActivity();
        // reflectionActivity.Run();

        // ListingActivity listingActivity= new ListingActivity();
        // listingActivity.Run(); 
*/

        Boolean done = false;
        while (!done)
        {

            Activity activity= new Activity();
            Console.WriteLine("Loading...");
            activity.ShowSpinner(5);

            Console.WriteLine("What activity do you want to do?");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Listing");
            Console.WriteLine("3. Reflection");
            Console.WriteLine("4. Quit");

            String response = Console.ReadLine();   

            if (response == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
                breathed++;
            }
            else if (response == "2")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
                listed++;
            }
            else if (response == "3")
            {
                ReflectionActivity reflectionActivity = new ReflectionActivity();
                reflectionActivity.Run();
                reflected++;
            }
            else if (response == "4")
            {
                done = true;
            }
            else
            {
                Console.WriteLine("Invalid value. Please enter a number listed.");
            }
        }
    }
}