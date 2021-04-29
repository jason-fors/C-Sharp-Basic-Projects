using System;

namespace ClassAndMethod2.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Instantiating MathOperations object so we can use its methods.
            MathOperations mathOperations1 = new MathOperations();

            // Obtaining numbers from the user to perform math operations on.
            Console.WriteLine("Pick an integer to multiply.");
            int userNumber1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Pick another integer to multiply (optional). If you don't pick a number, your number will be multiplied by 2.");
            
            string userResponse2 = Console.ReadLine();

            int product;  // Declaring product variable here rather than as local variable in if/else.

            if (userResponse2 == "")
            {
                product = mathOperations1.multiply(userNumber1);
            }
            else
            {
                int userNumber2 = Convert.ToInt32(userResponse2);
                product = mathOperations1.multiply(userNumber1, userNumber2);
            }
            
            Console.WriteLine("The product is: " + product);

            Console.ReadLine();
        }
    }
}
