using System;

namespace EnumsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
                       

            try
            {
                
                // Ask user for a day of the week
                Console.WriteLine("Please enter the current day of the week.");
                string thisDay = Console.ReadLine();

                // Creating enum variable type here so it is not local to the switch statement.
                DaysOfTheWeek today;
                
                // Parsing response to assign the variable based on user input.
                switch (thisDay)
                {
                    case "Monday":
                        today = DaysOfTheWeek.Monday;
                        break;
                    case "Tuesday":
                        today = DaysOfTheWeek.Tuesday;
                        break;
                    case "Wednesday":
                        today = DaysOfTheWeek.Wednesday;
                        break;
                    case "Thursday":
                        today = DaysOfTheWeek.Thursday;
                        break;
                    case "Friday":
                        today = DaysOfTheWeek.Friday;
                        break;
                    case "Saturday":
                        today = DaysOfTheWeek.Saturday;
                        break;
                    case "Sunday":
                        today = DaysOfTheWeek.Sunday;
                        break;
                    default:
                        throw new Exception();
                }

                Console.WriteLine(today);

            }
            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }


            Console.ReadLine();
        }

    }

    public enum DaysOfTheWeek
    {
        Monday, 
        Tuesday,
        Wednesday,
        Thursday, 
        Friday, 
        Saturday,
        Sunday
    }
}
