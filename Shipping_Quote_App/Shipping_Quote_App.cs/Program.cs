using System;

namespace Shipping_Quote_App.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcomes customer and asks for package weight. Using decimal type because we are dealing with money.
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("How much does your package weigh?");
            decimal weight = Convert.ToDecimal(Console.ReadLine());

            // Checks if package is too heavy to be shipped (over 50 pounds) and notifies customer if it is.
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }

            // This branch continues to process. Asking customer for dimensions
            else
            {
                Console.WriteLine("What is the width of your package?");
                decimal width = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("What is the height of your package?");
                decimal height = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("What is the length of your package?");
                decimal length = Convert.ToDecimal(Console.ReadLine());

                // Checks of package is too large to be shipped (dimensions sum to over 100). Notifies customer if it is.
                if (width + height + length > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }

                // This branch continues the process. Provides quote to customer.
                else
                {
                    decimal quote = (height * width * length * weight / 100);
                    
                    // Notifies customer of quote. Converting quote to money format (2 decimal places) and then to string.
                    Console.WriteLine("Your estimated total for shipping this package is $" + Math.Round(quote, 2).ToString());
                    Console.WriteLine("Thank you!");
                }

            }


            Console.ReadLine();
        }
    }
}
