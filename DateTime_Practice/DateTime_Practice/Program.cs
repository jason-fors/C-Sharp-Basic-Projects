using System;

namespace DateTime_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display current time to console.
            DateTime currentTime = DateTime.Now;
            Console.WriteLine(currentTime);

            // Get a number from user and add it to current datetime.
            Console.WriteLine("Please give me a number.");
            double hours = Convert.ToDouble(Console.ReadLine());
            DateTime newTime = currentTime.AddHours(hours);

            // Display new datetime in console.
            Console.WriteLine(newTime);


        }
    }
}
