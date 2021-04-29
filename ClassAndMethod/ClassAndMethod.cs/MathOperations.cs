using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAndMethod.cs
{
    // Creates a class for math operations
    public class MathOperations
    {

        // Takes an integer argument and returns the square
        public int Square(int userNum)  
        {
            return userNum * userNum;
        }

        // Takes an integer argument and returns its sum with 4
        public int PlusFour(int userNum)
        {
            return userNum + 4;
        }

        // Takes an integer argument and returns its product with 5
        public int TimesFive(int userNum)
        {
            return userNum * 5;
        }
    }
}
