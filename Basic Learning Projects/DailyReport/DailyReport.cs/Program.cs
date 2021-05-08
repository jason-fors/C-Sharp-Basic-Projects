using System;

namespace DailyReport.cs
{
    class Report
    {
        static void Main()
        {
            
            Console.WriteLine("The Tech Academy\n Student Daily Report");

            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();            // Gets user input and stores it in string variable.
            
            Console.WriteLine("What course are you on?");
            string userCourse = Console.ReadLine();
            
            Console.WriteLine("What page number?");
            string courseNumber = Console.ReadLine();
            int courseNum = Convert.ToInt32(courseNumber);   // Casts response to integer data type. Requires user to provide an answer in integer form.
            
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string needHelp = Console.ReadLine();
            bool helpBool = Convert.ToBoolean(needHelp);     // Casts response to boolean data type. Requires user to provide exactly "true" or "false".

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string positiveExperiences = Console.ReadLine();
            
            Console.WriteLine("How many hours did you study today?");
            string hoursStudied = Console.ReadLine();
            int hoursInt = Convert.ToInt32(hoursStudied);    // Casts response to integer data type. Requires user to provide an answer in integer form.

            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly.\nHave a great day!");
            Console.WriteLine("Close window to exit.");      // Informs user they must close the window to exit the program.
            Console.ReadLine();                              // Keeps program running until user closes window.
        }
    }
}
