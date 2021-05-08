using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAndMethod.cs
{
    // Creates a class for math operations
    public class MathOperations
    {

        // Takes an integer argument and returns the square
        public int Operation(int userNum)  
        {
            return userNum * userNum;
        }

        // Takes a decimal argument and returns the result of it being divided by 4. Using method overloading.
        public int Operation(decimal userNum)
        {
            int result = Convert.ToInt32(userNum/4);
            return result;
        }

        // Takes an string argument and returns its product with 5. Using method overloading.
        public int Operation(string userNum)
        {
            // Attempts to convert user string input to an integer and notifies user if it fails.
            try
            {
                int factor = Convert.ToInt32(userNum);
                return factor * 5;
            }
            catch (Exception)
            {
                Console.WriteLine("I couldn't convert that into an integer.");
                return 0;
            }

        }
    }
}
