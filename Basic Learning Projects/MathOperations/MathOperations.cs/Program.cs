using System;

namespace MathOperations.cs
{
    class Program
    {
        static void Main()
        {
            // This code is self-commenting. Just some basic math operations, with casting of variable types where necessary.

            Console.WriteLine("Please give me a number: ");
            double userNumber = Convert.ToDouble(Console.ReadLine());
            double timesFifty = userNumber * 50;
            Console.WriteLine("Your number times 50 is: " + timesFifty);

            Console.WriteLine("Please give me an integer: ");
            int userNumber2 = Convert.ToInt32(Console.ReadLine());
            int add25 = userNumber2 + 25;
            Console.WriteLine("Your number plus 25 is: " + add25);

            Console.WriteLine("Please give me an decimal: ");
            double userNumber3 = Convert.ToDouble(Console.ReadLine());
            double dividing = userNumber3 / 12.5;
            Console.WriteLine("Your number divided by 12.5 is: " + dividing);

            Console.WriteLine("Please give me an integer: ");
            int userNumber4 = Convert.ToInt32(Console.ReadLine());
            int modulo7 = userNumber4 % 7;
            Console.WriteLine("The remainder when your number is divided by 7 is: " + modulo7);
            
            Console.ReadLine();  // To keep window open
        }
    }
}
