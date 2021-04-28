using System;
using System.Collections.Generic;

namespace TryCatch.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a list of integers to divide a user number by.
            List<int> myList = new List<int>();
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);
            myList.Add(22);
            myList.Add(354);
            myList.Add(3456);

            // Adding try/catch block to handle exceptions (e.g., non-integer entries or zero)
            try
            {
                Console.WriteLine("Pick a number.");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                // Iterates through integer list and divides each number by user's number
                foreach (int number in myList)
                {
                    Console.WriteLine(number + " divided by " + userNumber + " = " + number / userNumber);

                }
            }
            catch (Exception ex)        // Catching all exceptions. Storing exception info in variable "ex".
            {
                Console.WriteLine(ex.Message);      // Printing exception message to console.
            }

            Console.WriteLine("Try-Catch block complete.");     // Notification that try/catch is complete.

        }
    }
}
