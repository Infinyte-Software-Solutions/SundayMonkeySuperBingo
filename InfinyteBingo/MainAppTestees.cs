using System;
using System.Drawing;


namespace InfinyteBingo
{
    class MainAppTestees 
    {
        static void Main(string[] args)
        {
            // Main Application Testing Area
            // This is the only place in this Solution where you can actually create, modify and delete 
            // Objects(Classes) in Memory.

            String DebugLine = "";      // A Variable to temporarily hold a line of Debugging Output

            // Insert Testing Code After This Message 
            Display("\n\n\n***** Beginning of Debuggin Output for The Basic Ass Bingo Engine *******\n\n\n");

            // Your Code goes here ()=====>
            Display("Insert Your ()=========>\'in Around Here!");

            BallSet myDogsBalls = new BallSet();

            myDogsBalls.PopulateStandardBingoBallSet();

            Display("Number of Balls in set is : " + myDogsBalls.BallSetSize);
            
            // End of your code - These Lines are to keep the console open till you press enter
            Display("\n\n\n***** End of Debugging Output! Press Enter to Continue/Quit ***********");
            DebugLine = System.Console.ReadLine();
            
        }

        // Static Helper Method to Display a String to the Console
        static void Display(String s)
        {
            System.Console.Out.WriteLine(s);
        }

       
    }
}
