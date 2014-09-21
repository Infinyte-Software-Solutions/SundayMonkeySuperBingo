using System;
using System.Drawing;

namespace InfinyteBingo
{
    class Ball 
    {
        // Properties
        // Private Member Variables
        private char _letter;               // The Letter Of The Ball (B,I,N,G,O) 
        private int _number;                // The Number on the Ball (1-75)
        private Color _ballColor;           // The Color of The Ball (Blue, Indigo, Red, Green, Orange)

        // Constructors
        
        // Default Constructor
        public Ball()
        {
            // Setting all of the ball's default properties to invalid values.
            _letter = 'Z';
            _number = 0;
            _ballColor = Color.Transparent;
        }

        // Overloaded Constructor
        // @Params :(int i-> The Ball's integer value
        public Ball(int n)
        {
            // Setting all of the ball's default properties
            SetNumber(n);

            if ((n > 0) && (n < 16))
            {
                SetLetter('B');
                SetColor(Color.Blue);
            }

            if ((n > 15) && (n < 31))
            {
                SetLetter('I');
                SetColor(Color.Indigo);
            }

            if ((n > 30) && (n < 46))
            {
                SetLetter('N');
                SetColor(Color.Red);
            }

            if ((n > 45) && (n < 61))
            {
                SetLetter('G');
                SetColor(Color.Green);
            }

            if ((n > 60) && (n < 76))
            {
                SetLetter('O');
                SetColor(Color.Orange);
            }
        }
        
        // Overloaded Constructor 
        // @params : (char BallsLetter, int BallsNumber, Color BallsColor)
        public Ball(char l, int n, Color c)
        { 
            _letter = l;
            _number = n;
            _ballColor = c;
        }

        // Class Methods

        // Is Ball Valid Method
        public bool IsBallValid()
        {
            // Test Balls that are B
            if (GetLetter() == 'B')
            {
                if ((GetNumber() > 0) && (GetNumber() < 16))
                {
                    if (GetColor() == Color.Blue)
                        return true;
                }
            }
            // Test Balls that are I
            if (GetLetter() == 'I')
            {
                if ((GetNumber() > 15) && (GetNumber() < 31))
                {
                    if (GetColor() == Color.Indigo)
                        return true;
                }
            }
            // Test Balls that are N
            if (GetLetter() == 'N')
            {
                if ((GetNumber() > 30) && (GetNumber() < 46))
                {
                    if (GetColor() == Color.Red)
                        return true;
                }
            }
            // Test Balls that are G
            if (GetLetter() == 'G')
            {
                if ((GetNumber() > 45) && (GetNumber() < 61))
                {
                    if (GetColor() == Color.Green)
                        return true;
                }
            }
            // Test Balls that are O
            if (GetLetter() == 'O')
            {
                if ((GetNumber() > 60) && (GetNumber() < 76))
                {
                    if (GetColor() == Color.Orange)
                        return true;
                }
            }
            return false;
        }
      
        // Ball Properties Public Get/Set Methods
        public char GetLetter()
        {
            return _letter;
        }

        public int GetNumber()
        {
            return _number;
        }

        public Color GetColor()
        {
            return _ballColor;
        }

        public void SetLetter(char l)
        {
            _letter = l;
        }

        public void SetNumber(int n)
        {
            _number = n;
        }

        public void SetColor(Color c)
        {
            _ballColor = c;
        }

        // Setter to Set All of Ball's Properties
        public void SetAllProperties(char l, int n, Color c)
        {
            SetNumber(n);
            SetColor(c);
            SetLetter(l);
        }

        // Debug Methods 
        
        // Output Ball's Details to Console
        public void ShowDetails()
        {
            Console.WriteLine(GetDetailsString());
        }

        // Get a String containing All of Ball's Private Properties Info (Letter,Number and Color)
        public String GetDetailsString() 
        {
            return (_letter + " " + _number + ", is " + _ballColor + '\n');
        }
    }
}