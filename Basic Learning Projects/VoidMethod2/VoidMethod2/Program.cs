using System;

namespace VoidMethod2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate class
            DivideByTwo divideByTwo = new DivideByTwo();

            // Get number from user and call divide2 method from class, displaying output parameter to console
            Console.WriteLine("Enter a number.");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            divideByTwo.Divide2(userNumber, out int result1);
            Console.WriteLine(result1);

            // Change number with static method and calling overloaded method (no out parameter, method displays result to console).
            DivideByTwo.setDivisor(3);
            divideByTwo.Divide2(userNumber);
        }
    }
}
