using System;

namespace Insurance_Approval.cs
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("This is a short approval screener for car insurance.");
            Console.WriteLine("What is your age? (Please provide a number.)");
            int ageResponse = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? (Please answer 'true' for yes or 'false' for no.");
            bool duiResponse = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets to you have? (Please provide a number.)");
            int ticketsResponse = Convert.ToInt32(Console.ReadLine());

            // Checking to make sure user is over 15, has not had a DUI, and has no more than 3 speeding tickets.
            bool qualified = (ageResponse > 15 && duiResponse == false && ticketsResponse < 4);
            Console.WriteLine("Qualified?");
            Console.WriteLine(qualified);
            
            Console.ReadLine();

        }
    }
}
