using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace InfinyteBingo
{
    class BallSet
    {
        // Member Variables
        private HashSet<Ball> _Balls;
        public String SetName { get; set; }

        public int BallSetSize { get { return _Balls.Count; } private set { } }

        // Constructors
        public BallSet()
        {
            _Balls = new HashSet<Ball>();
            BallSetSize = _Balls.Count;
            SetName = "Default BallSet!";
        }

        // Member Methods
        
        // Clear Current Ballset
        public void ClearBallSet()
        {
            _Balls.Clear();
            BallSetSize = _Balls.Count;
            SetName = "Empty BallSet";
        }
        
        // Random Num Generator
        public int GenerateRandomBoundedInt(int min, int max)
        {
            // Random Number Generator (Seeded by Current System Time's millisecond value
            Random moneyMaker = new Random();
            Thread.Sleep(500);
            int x = moneyMaker.Next(min, max);
            
            return x;
        }

        // Generate a 75 Ball Standard Bingo Ball Set
        public void PopulateStandardBingoBallSet()
        {
            for (int i = 1; i < 16; i++)
            {
                Ball b = new Ball('B', i, Color.Blue);
                _Balls.Add(b);
                BallSetSize = _Balls.Count;
            }
            for (int i = 16; i < 31; i++)
            {
                Ball b = new Ball('I', i, Color.Indigo);
                _Balls.Add(b);
                BallSetSize = _Balls.Count;
            }
            for (int i = 31; i < 46; i++)
            {
                Ball b = new Ball('N', i, Color.Red);
                _Balls.Add(b);
                BallSetSize = _Balls.Count;
            }
            for (int i = 46; i < 61; i++)
            {
                Ball b = new Ball('G', i, Color.Green);
                _Balls.Add(b);
                BallSetSize = _Balls.Count;
            }
            for (int i = 61; i < 76; i++)
            {
                Ball b = new Ball('O', i, Color.Orange);
                _Balls.Add(b);
                BallSetSize = _Balls.Count;
            }
        }

        public void AddBall(Ball b)
        {
            _Balls.Add(b);
            BallSetSize = _Balls.Count;
        }
        public Ball RemoveLastBall()
        {
            Ball b = _Balls.ElementAt(_Balls.Count);
            _Balls.Remove(b);
            BallSetSize = _Balls.Count;
            return b;
        }
        public Ball RemoveBall(int n)
        {

            Ball b = _Balls.ElementAt(n);
            _Balls.Remove(b);
            BallSetSize = _Balls.Count;
            return b;
        }

        public void ShowBallSetDetails()
        {
            foreach (Ball ball in _Balls)
            {
                ball.ShowDetails();
            }
            
            //for (int i = 1; i < BallSetSize; i++)
            //{
            //    Ball b = _Balls.ElementAt(i);
            //    b.ShowDetails();
            //}
        }

    }
}
