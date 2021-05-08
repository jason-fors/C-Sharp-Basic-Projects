using System;
using System.Collections.Generic;

namespace ArraysAndListsApp.cs
{
    class Program
    {
        static void Main()
        {
            // Creates a one-dimensional Array of strings.
            string[] nameArray = { "Jason", "Kirstine", "Wilson", "Shadow", "Nathan", "Sydney" };

            // Asks the user to select an index of the Array.
            Console.WriteLine("Pick a number 0 to 5.");
            int chosenName = Convert.ToInt32(Console.ReadLine());

            // Adds a message that displays when the user selects an index that doesn’t exist.
            if (chosenName < 0 || chosenName > 5)
            {
                Console.WriteLine("That number is not between 0 and 5!");
            }
            else
            {
                // Displays the string at that index on the screen.
                Console.WriteLine("You chose: " + nameArray[chosenName]);
            }

            // Creates a one-dimensional Array of integers.
            // Asks the user to select an index of the Array and then displays the integer at that index on the screen.
            int[] intArray = { 2, 3, 5, 7, 11, 13 };
            Console.WriteLine("Pick a number 0 to 5.");

            int chosenInt = Convert.ToInt32(Console.ReadLine());

            // Adds a message that displays when the user selects an index that doesn’t exist.
            if (chosenName < 0 || chosenName > 5)
            {
                Console.WriteLine("That number is not between 0 and 5!");
            }
            else
            {
                Console.WriteLine("You chose: " + intArray[chosenInt]);
            }





            Console.ReadLine();
        }
    }
}
