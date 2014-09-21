using System;

namespace InfinyteBingo
{
    class SuperBallPopper
    {
        public BallSet BingoBallSet { get; set; }

        private Ball _poppedBall;

        public int PoppersCapacity { get; set; }

        // Constructors
        public SuperBallPopper()
        {
            BingoBallSet = new BallSet();
            _poppedBall = new Ball();
            PoppersCapacity = 0;
        }

        // Overloaded Constructor
        public SuperBallPopper(int popperMaxCapacity)
        {
            BingoBallSet = new BallSet();
            _poppedBall = new Ball();
            PoppersCapacity = popperMaxCapacity;
            
            // Num of Balls for a Standard Game
            if (PoppersCapacity == 75)
            {
                BingoBallSet.PopulateStandardBingoBallSet();
                BingoBallSet.SetName = ("Standard Bingo Game Popper Created with " + BingoBallSet.BallSetSize + " balls.\n");
            }
            else // MaxCapacity !75
            {
                for (int i = 1; i < popperMaxCapacity; i++)
                {
                    var b = new Ball(i);
                    BingoBallSet.AddBall(b);
                }
                BingoBallSet.SetName = ("Custom Bingo Game Popper Created with " + BingoBallSet.BallSetSize + " balls\n");
            }
        }

        // Member Methods
        //
        public Ball PopBall()
        {
            var nullBall = new Ball();

            if (PoppersCapacity <= 0) return nullBall;
            if (BingoBallSet.BallSetSize <= 0) return nullBall;
            var randomNumGenerator = new Random();
            var randomBall = randomNumGenerator.Next(BingoBallSet.BallSetSize);
            _poppedBall = BingoBallSet.RemoveBall(randomBall);
            return _poppedBall;
        }
    }
}