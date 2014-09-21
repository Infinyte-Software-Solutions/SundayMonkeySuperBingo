using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;

namespace InfinyteBingo
{
    class BallSet
    {
        // Member Variables
        private HashSet<Ball> _balls;

        public String SetName { get; set; }

        public HashSet<Ball> Balls
        {
            get
            {
                return _balls;
            }
            set
            {
                _balls = value;
            }
        }

        public int BallSetSize
        {
            get
            {
                return _balls.Count;
            }
            // ReSharper disable once ValueParameterNotUsed
            private set { }    
        }

        // Constructors
        public BallSet()
        {
            _balls = new HashSet<Ball>();
            BallSetSize = _balls.Count;
            SetName = "Default BallSet!";
        }

        // Member Methods
        
        // Clear Current Ball set
        public void ClearBallSet()
        {
            _balls.Clear();
            BallSetSize = _balls.Count;
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
                _balls.Add(b);
                BallSetSize = _balls.Count;
            }
            for (int i = 16; i < 31; i++)
            {
                Ball b = new Ball('I', i, Color.Indigo);
                _balls.Add(b);
                BallSetSize = _balls.Count;
            }
            for (int i = 31; i < 46; i++)
            {
                Ball b = new Ball('N', i, Color.Red);
                _balls.Add(b);
                BallSetSize = _balls.Count;
            }
            for (int i = 46; i < 61; i++)
            {
                Ball b = new Ball('G', i, Color.Green);
                _balls.Add(b);
                BallSetSize = _balls.Count;
            }
            for (int i = 61; i < 76; i++)
            {
                Ball b = new Ball('O', i, Color.Orange);
                _balls.Add(b);
                BallSetSize = _balls.Count;
            }
        }

        public void AddBall(Ball b)
        {
            _balls.Add(b);
            BallSetSize = _balls.Count;
        }

        public Ball RemoveLastBall()
        {
            Ball b = _balls.Last();
            _balls.Remove(b);
            BallSetSize = _balls.Count;
            return b;
        }

        public Ball RemoveBall(int n)
        {
            Ball b = _balls.ElementAt(n);
            _balls.Remove(b);
            BallSetSize = _balls.Count;
            return b;
        }

        public void ShowBallSetDetails()
        {
            foreach (Ball ball in _balls)
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