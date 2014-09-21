﻿using System;

namespace InfinyteBingo
{
    class MainAppTestees 
    {
        // ReSharper disable once UnusedParameter.Local
        static void Main(string[] args)
        {
            // Main Application Testing Area
            // This is the only place in this Solution where you can actually create, modify and delete 
            // Objects(Classes) in Memory.

            // Insert Testing Code After This Message 
            Display("\n\n\n***** Beginning of Debuggin Output for The Basic Ass Bingo Engine *******\n\n\n");

            // Your Code goes here ()=====>
            Display("Insert Your ()=========>\'in Around Here!");

            var popper = new SuperBallPopper(75);

            Display("My Popper : holds" + popper.PoppersCapacity);

            var myball = popper.PopBall();
            myball.ShowDetails();
            myball = popper.PopBall();
            myball.ShowDetails();
            
            myball.ShowDetails();
            
            // End of your code - These Lines are to keep the console open till you press enter
            Display("\n\n\n***** End of Debugging Output! Press Enter to Continue/Quit ***********");
            Console.ReadLine();
        }

        // Static Helper Method to Display a String to the Console
        static void Display(String s)
        {
            Console.Out.WriteLine(s);
        }
    }
}