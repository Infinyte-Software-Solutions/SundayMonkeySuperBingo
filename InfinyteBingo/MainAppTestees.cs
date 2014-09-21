using System;

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
            var defaultPopper = new SuperBallPopper();
            var hunPopper = new SuperBallPopper(100);

            Display("I have created 3 poppers!!!");
            
            Display("Default Popper has a max capacity of :" + defaultPopper.PoppersCapacity + " Balls.");
            Display("Default Popper holds: " + defaultPopper.BingoBallSet.BallSetSize + " Balls");

            Display("Ballset Details: ");
            defaultPopper.BingoBallSet.ShowBallSetDetails();

            defaultPopper.BingoBallSet.ClearBallSet();
            
            defaultPopper.BingoBallSet.AddBall(new Ball(20));
            defaultPopper.BingoBallSet.AddBall(new Ball(50));
            defaultPopper.BingoBallSet.AddBall(new Ball(10));
            defaultPopper.BingoBallSet.AddBall(new Ball(27));
            defaultPopper.BingoBallSet.AddBall(new Ball(75));
            var myBall = defaultPopper.PopBall();
            myBall.ShowDetails();
            myBall = defaultPopper.PopBall();
            myBall.ShowDetails();

            Display("Ballset Details: ");
            defaultPopper.BingoBallSet.ShowBallSetDetails();


            //Display("Main Popper has a max capacity of :" + popper.PoppersCapacity + " Balls.");
            //Display("Default Popper holds: " + popper.BingoBallSet.BallSetSize + " Balls");

            //Display("Ballset Details: ");
            //popper.BingoBallSet.ShowBallSetDetails();

            //Display("Default Popper has a max capacity of :" + hunPopper.PoppersCapacity + " Balls.");
            //Display("Default Popper holds: " + hunPopper.BingoBallSet.BallSetSize + " Balls");

            //Display("Ballset Details: ");
            //hunPopper.BingoBallSet.ShowBallSetDetails();




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