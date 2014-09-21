using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfinyteBingo
{
    class SuperBallPopper
    {
        private BallSet _BingoBallSet { get; set; }
        private Ball _PoppedBall;

        public int PoppersCapacity { get; set; }



        // Constructors
        public SuperBallPopper()
        {
            _BingoBallSet = new BallSet();
            _PoppedBall = new Ball();
            PoppersCapacity = 0;
        }
        // Overloaded Constructor
        public SuperBallPopper(int popperMaxCapacity)
        {
            _BingoBallSet = new BallSet();
            _PoppedBall = new Ball();
            PoppersCapacity = popperMaxCapacity;
            
            // Num of Balls for a Standard Game
            if (PoppersCapacity == 75)
            {
                _BingoBallSet.PopulateStandardBingoBallSet();
                _BingoBallSet.SetName = ("Standard Bingo Game Popper Created with " + _BingoBallSet.BallSetSize + " balls.\n");
            }
            else    // MaxCapacity !75
            {
                for (int i = 1; i < popperMaxCapacity; i++)
                {
                    Ball b = new Ball(i);
                    _BingoBallSet.AddBall(b);
                }
                _BingoBallSet.SetName = ("Custom Bingo Game Popper Created with " + _BingoBallSet.BallSetSize + " balls\n");
            }
        }
        // Member Methods
        //
        public Ball PopBall()
        {
            Ball nullBall = new Ball();
           
            if (PoppersCapacity > 0)
            {
                if (_BingoBallSet.BallSetSize > 0)
                {
                    Random randomNumGenerator = new Random();
                    int randomBall = randomNumGenerator.Next(_BingoBallSet.BallSetSize);
                    _PoppedBall = _BingoBallSet.RemoveBall(randomBall);
                    return _PoppedBall;
                }
            }
            return nullBall;
        }
    }
}
