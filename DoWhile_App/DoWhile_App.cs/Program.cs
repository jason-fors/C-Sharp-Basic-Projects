using System;

namespace DoWhile_App.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepPlaying = true;

            while (keepPlaying)
            {
                // Gets a number from the user
                Console.WriteLine("Pick a number for me to count to.");
                int userNum = Convert.ToInt32(Console.ReadLine());

                // Starts count at 1
                int i = 1;

                // Counts to the users number. With the do-while loop, will include 1 if the user picks a number less than 1.
                do
                {
                    Console.WriteLine("Count: " + i.ToString());
                    i++;

                } while (i <= userNum);


                // Asks user if they want to play again.
                Console.WriteLine("Type 'y' to play again.");
                string playAgain = Console.ReadLine();

                if (playAgain == "y")
                {
                    keepPlaying = true;
                }
                else
                {
                    keepPlaying = false;
                }
            }
        }
    }
}
