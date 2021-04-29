using System;

namespace ClassAndMethod.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Obtaining an number from the user to perform math operations on.
            Console.WriteLine("Pick a number to perform some math operations on!");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            // Instantiating MathOperations object so we can use its methods.
            MathOperations mathOperations = new MathOperations();

            // Calling each MathOperations method on the user number and assigning each result to a varible.
            int squared = mathOperations.Square(userNumber);
            int plusFour = mathOperations.PlusFour(userNumber);
            int timesFive = mathOperations.TimesFive(userNumber);

            // Displaying results to user on console.
            Console.WriteLine("Your number squared is: " + squared);
            Console.WriteLine("Your number plus four is: " + plusFour);
            Console.WriteLine("Your number times five is: " + timesFive);


            Console.ReadLine();
        }
    }
}
