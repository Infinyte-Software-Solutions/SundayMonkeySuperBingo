using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    
 namespace InfinyteBingo
{
    class BallSet
    {
        // Member Variables
        private HashSet<Ball> _Balls;
       
        public int BallSetSize { get; set; }
        
        // Constructors
        public BallSet()
        {
            _Balls = new HashSet<Ball>();
            BallSetSize = 0;
        }

        // Member Methods
        public void PopulateStandardBingoBallSet()
        {
            for (int i = 1; i < 16; i++)
            {
                Ball b = new Ball('B', i, Color.Blue);
                _Balls.Add(b);
                BallSetSize = BallSetSize + 1;
            }
            for (int i = 16; i < 31; i++)
            {
                Ball b = new Ball('I', i, Color.Indigo);
                _Balls.Add(b);
                BallSetSize = BallSetSize + 1;
            }
            for (int i = 31; i < 46; i++)
            {
                Ball b = new Ball('N', i, Color.Red);
                _Balls.Add(b);
                BallSetSize = BallSetSize + 1;
            }
            for (int i = 46; i < 61; i++)
            {
                Ball b = new Ball('G', i, Color.Green);
                _Balls.Add(b);
                BallSetSize = BallSetSize + 1;
            }
            for (int i = 61; i < 76; i++)
            {
                Ball b = new Ball('O', i, Color.Orange);
                _Balls.Add(b);
                BallSetSize = BallSetSize + 1;
            }
        }

        public void AddBall(Ball b)
        {
            _Balls.Add(b);
            BallSetSize += 1;
        }

        public void RemoveBall(Ball b)
        {
            _Balls.Remove(b);
            BallSetSize -= 1;
        }

        public void ShowBallSetDetails()
        {
            
            for (int i = 1; i > BallSetSize; i++)
            {
               
            }
        }
    }
}
