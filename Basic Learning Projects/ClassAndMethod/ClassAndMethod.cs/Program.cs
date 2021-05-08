using System;

namespace ClassAndMethod.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating MathOperations object so we can use its methods.
            MathOperations mathOperations1 = new MathOperations();

            // Obtaining an number from the user to perform math operations on.
            Console.WriteLine("Pick an integer to square.");
            int userNumber1 = Convert.ToInt32(Console.ReadLine());
            int squared = mathOperations1.Operation(userNumber1);
            Console.WriteLine("Your number squared is: " + squared);

            // Instantiating MathOperations object so we can use its methods.
            MathOperations mathOperations2 = new MathOperations();

            Console.WriteLine("Pick a decimal to divide by four.");
            decimal userNumber2 = Convert.ToDecimal(Console.ReadLine());
            int dividedByFour = mathOperations2.Operation(userNumber2);
            Console.WriteLine("Your number divided by four is: " + dividedByFour);

            // Instantiating MathOperations object so we can use its methods.
            MathOperations mathOperations3 = new MathOperations();
            
            Console.WriteLine("Pick an number to multiply by five.");
            string userNumber3 = Console.ReadLine();
            int timesFive = mathOperations3.Operation(userNumber3);
            Console.WriteLine("Your number times five is: " + timesFive);

            Console.ReadLine();
        }
    }
}
