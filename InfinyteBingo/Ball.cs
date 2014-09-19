using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InfinyteBingo
{
    class Ball 
    {
        // Properties
        
        // Private Member Variables
        private char _Letter;               // The Letter Of The Ball (B,I,N,G,O) 
        private int _Number;                // The Number on the Ball (1-75)
        private Color _BallColor;           // The Color of The Ball (Blue, Purple, Red, Green, Orange)


        // Constructors
        
        // Default Constructor
        public Ball()
        {
            // Setting all of the ball's default properties to invalid values.
            _Letter = 'Z';
            _Number = 0;
            _BallColor = Color.Transparent;
        }
        
        // Overloaded Constructor 
        // @params : (char BallsLetter, int BallsNumber, Color BallsColor)
        public Ball(char l, int n, Color c)
        {
            
            
            _Letter = l;
            _Number = n;
            _BallColor = c;
        }

        // Class Methods

        // Is Ball Valid Method
        public bool isBallValid()
        {
            
            // Test Balls that are B
            if (GetLetter() == 'B')
            {
                if ( (GetNumber() > 0) && (GetNumber() < 16) )
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
            return _Letter;
        }

        public int GetNumber()
        {
            return _Number;
        }
        public Color GetColor()
        {
            return _BallColor;
        }

        public void SetLetter(char l)
        {
            _Letter = l;
        }

        public void SetNumber(int n)
        {
            _Number = n;
        }
        public void SetColor(Color c)
        {
            _BallColor = c;
        }

        // Setter to Set All of Ball's Properties
        public void SetAllProperties(char l, int n, Color c)
        {
            this.SetNumber(n);
            this.SetColor(c);
            this.SetLetter(l);
        }

        // Debug Methods 
        
        // Output Ball's Details to Console
        public void ShowDetails()
        {
            System.Console.WriteLine( this.GetDetailsString() );
        }

        // Get a String containing All of Ball's Private Propertie's Info (Letter,Number and Color)
        public String GetDetailsString() 
        {
            return (_Letter + " " + _Number +  ", is " + _BallColor + '\n');
        }
    
    }
}
