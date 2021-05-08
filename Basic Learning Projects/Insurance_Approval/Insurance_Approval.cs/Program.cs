using System;
using System.Text;
using System.Collections.Generic;

namespace Insurance_Approval.cs
{
    class Program
    {
        static void Main()
        {
            //Console.WriteLine("This is a short approval screener for car insurance.");
            //Console.WriteLine("What is your age? (Please provide a number.)");
            //int ageResponse = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Have you ever had a DUI? (Please answer 'true' for yes or 'false' for no.");
            //bool duiResponse = Convert.ToBoolean(Console.ReadLine());
            //Console.WriteLine("How many speeding tickets to you have? (Please provide a number.)");
            //int ticketsResponse = Convert.ToInt32(Console.ReadLine());

            //// Checking to make sure user is over 15, has not had a DUI, and has no more than 3 speeding tickets.
            //bool qualified = (ageResponse > 15 && duiResponse == false && ticketsResponse <= 3);

            //if (qualified)
            //{
            //    Console.WriteLine("You are qualified!");
            //}
            //else if (qualified != true)
            //{
            //    Console.WriteLine("I'm sorry, you are not qualified.");
            //}

            //// Ternary operator version
            //string application_result = (ageResponse > 15 && duiResponse == false && ticketsResponse <= 3) ? "You are qualified!" : "I'm sorry, you are not qualified."; 

            //Console.WriteLine(application_result);

            //int roomTemperature = 70;

            //Console.WriteLine("Hi, what is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("Hi, " + name + ", what is the temperature where you are?");
            //int currentTemperature = Convert.ToInt32(Console.ReadLine());

            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly room temperature.");
            //}

            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("It is warmer than room temperature.");
            //}

            //else if (currentTemperature < roomTemperature)
            //{
            //    Console.WriteLine("It is cooler than room temperature.");
            //}

            //else
            //{
            //    Console.WriteLine("Something went wrong.");
            //}


            //Console.WriteLine("What is your favorite number?");
            //int favNum = Convert.ToInt32(Console.ReadLine());

            //string result1 = favNum == 12 ? "You have an awesome favorite number." : "You do not have an awesome favorite number";

            //Console.WriteLine(result1);


            //Console.WriteLine("Pick a number, 1 to 7.");
            //int day = Convert.ToInt32(Console.ReadLine()); ;
            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Thursday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Friday");
            //        break;
            //    case 6:
            //        Console.WriteLine("Saturday");
            //        break;
            //    case 7:
            //        Console.WriteLine("Sunday");
            //        break;
            //}


            //bool isGuessed = false;

            //while (!isGuessed)
            //{
            //    Console.WriteLine("Pick a number, 1 to 7.");
            //    int userNum = Convert.ToInt32(Console.ReadLine()); ;
            //    switch (userNum)
            //    {
            //        case 62:
            //            Console.WriteLine("You guessed 62. Try again.");
            //            break;
            //        case 29:
            //            Console.WriteLine("You guessed 29. Try again.");
            //            break;
            //        case 55:
            //            Console.WriteLine("You guessed 55. Try again.");
            //            break;
            //        case 12:
            //            Console.WriteLine("You guessed 12. That is correct!");
            //            isGuessed = true;
            //            break;
            //        default:
            //            Console.WriteLine("You are wrong.");
            //            break;
            //    }
            //}


            //string name = "Jesse";
            //string quote = "The man said \\ \"Hello\". \n Hello on a new line. \n \t Hello on a tab.";
            //// @ tells C# to ignore escape characters. Useful for filenames.
            //string fileName = @"C:\Users\Jesse";

            //bool TrueOrFalse = name.Contains("s");

            //// The StringBuilder class allows you to work with strings dynamically without the memory overhead.

            //StringBuilder sb = new StringBuilder();
            //sb.Append("My name is Jason. ");
            //sb.Append("I am learning C#. ");
            //sb.Append("Right now, I am using StringBuilder to make a paragraph.");


            //string newQuote = quote.ToUpper();

            //Console.WriteLine(newQuote);
            //Console.WriteLine(sb);
            //Console.ReadLine();


            // ITERATION PART ONE VIDEO

            //int[] testScores = { 98, 99, 95, 70, 82, 34, 90, 94 };

            //for (int i = 0; i < testScores.Length; i++)
            //{
            //    if (testScores[i] > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + testScores[i]);
            //    }
            //}

            //string[] nameLoop = { "Jesse", "Erik", "Daniel", "Adam" };

            //for (int j = 0; j < nameLoop.Length; j++)
            //{
            //    Console.WriteLine(nameLoop[j]);
            //}


            // Iteration for a list.
            List<int> testScores2 = new List<int>();
            testScores2.Add(98);
            testScores2.Add(99);
            testScores2.Add(81);
            testScores2.Add(72);
            testScores2.Add(70);

            List<int> passingScores = new List<int>();

            foreach (int score in testScores2)
            {
                if (score > 85)
                {
                    Console.WriteLine("Passing test score: " + score);
                    passingScores.Add(score);
                }
            }

            Console.WriteLine(passingScores.Count);


            List<string> names2 = new List<string>() { "Jesse", "Erik", "Adam", "Daniel" };

            foreach (string person in names2)
            {
                Console.WriteLine(person);
            }
        }
    }
}
